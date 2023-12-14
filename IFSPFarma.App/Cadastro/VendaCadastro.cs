using IFSPFarma.App.Models;
using IFSPFarmacia.Domain.Base;
using IFSPFarmacia.Domain.Entities;
using IFSPFarma.Service.Validators;
using System.Globalization;

namespace IFSPFarma.App.Cadastro
{
    public partial class VendaCadastro : CadastroBase
    {
        private List<VendaProdutoModel
            > _vendaProduto;
        private readonly IBaseService<Venda> _vendaService;
        private readonly IBaseService<Farmaceutico> _farmaceuticoService;
        private readonly IBaseService<Cliente> _clienteService;
        private readonly IBaseService<Produto> _produtoService;
        
        private List<VendaModel> vendas;

        public VendaCadastro(IBaseService<Venda> vendaService,
                             IBaseService<Cliente> clienteService,
                             IBaseService<Produto> produtoService,
                             IBaseService<Farmaceutico> farmaceuticoService
                             )    
        {
            
            _vendaService = vendaService;
            _clienteService = clienteService;
            _produtoService = produtoService;
            _farmaceuticoService = farmaceuticoService;
            _vendaProduto = new List<VendaProdutoModel>();
            InitializeComponent();
            CarregarCombo();
            CarregaGridItensVenda();
            Novo();
        }

        private void CarregarCombo()
        {
            cboCliente.ValueMember = "Id";
            cboCliente.DisplayMember = "Nome";
            cboCliente.DataSource = _clienteService.Get<Cliente>().ToList();

            cboFarmaceutico.ValueMember = "Id";
            cboFarmaceutico.DisplayMember = "Nome";
            cboFarmaceutico.DataSource = _farmaceuticoService.Get<Farmaceutico>().ToList();

            cboProdutos.ValueMember = "Id";
            cboProdutos.DisplayMember = "Descricao";
            cboProdutos.DataSource = _produtoService.Get<Produto>().ToList();
        }

        private void PreencheObjeto(Venda venda)
        {
            if (DateTime.TryParse(txtData.Text, out var data))
            {
                venda.Data = data;
            }

            if (int.TryParse(cboCliente.SelectedValue.ToString(), out var idCliente))
            {
                var cliente = _clienteService.GetById<Cliente>(idCliente);
                venda.Cliente = cliente;
            }

            if (int.TryParse(cboFarmaceutico.SelectedValue.ToString(), out var idFarmaceutico))
            {
                var farmaceutico = _farmaceuticoService.GetById<Farmaceutico>(idFarmaceutico);
                //new Farmaceutico() { Id= idFarmaceutico };

                venda.Farmaceutico = farmaceutico;
            }
            venda.TotalVenda = _vendaProduto.Sum(x => x.Total);

            foreach (var p in _vendaProduto)
            {
                var produtos = new VendaProduto
                {
                    Total = p.Total,
                    Desconto = p.Desconto,
                    Quantidade = p.Quantidade,
                    Vend = venda,
                    Prod = new Produto() { Id= p.IdProduto}
                    //_produtoService.GetById<Produto>(p.IdProduto)
                };

                venda.Produtos.Add(produtos);
            }
        }
        protected override void Novo()
        {
            base.Novo();
            _vendaProduto.Clear();
            CarregaGridItensVenda();
            txtData.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }

        protected override void Salvar()
        {
            try
            {
                if (IsAlteracao)
                {
                    if (int.TryParse(txtId.Text, out var id))
                    {
                        var venda = _vendaService.GetById<Venda>(id);
                        PreencheObjeto(venda);
                        venda = _vendaService.Update<Venda, Venda, VendaValidator>(venda);
                    }
                }
                else
                {
                    var venda = new Venda();
                    PreencheObjeto(venda);
                    venda = _vendaService.Add<Venda, Venda, VendaValidator>(venda);
                }

                materialTabControl1.SelectedIndex = 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, @"IFSP Farma", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected override void Deletar(int id)
        {
            try
            {
                _vendaService.Delete(id);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, @"IFSP Farma", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected override void CarregaGrid()
        {
            var includes = new List<string>() { "Cliente", "Farmaceutico" };
            vendas = _vendaService.Get<VendaModel>(includes).ToList();
            gridConsualta.DataSource = vendas;
            gridConsualta.Columns["IdCliente"]!.Visible = false;
            gridConsualta.Columns["IdFarmaceutico"]!.Visible = false;
        }

        protected override void CarregaRegistro(DataGridViewRow? linha)
        {
            int.TryParse(linha?.Cells["Id"].Value.ToString(), out var id);
            txtId.Text = linha?.Cells["Id"].Value.ToString();
            cboCliente.SelectedValue = linha?.Cells["IdCliente"].Value;
            cboFarmaceutico.SelectedValue = linha?.Cells["IdFarmaceutico"].Value;
            txtData.Text = DateTime.TryParse(linha?.Cells["Data"].Value.ToString(), out var dataC)
               ? dataC.ToString("g")
               : "";

            var includes = new List<string>() { "Cliente", "Farmaceutico", "Produtos", };
            var venda = _vendaService.GetById<Venda>(id, includes);
            _vendaProduto = new List<VendaProdutoModel>();
            foreach (var p in venda.Produtos)
            {
                var produtos = new VendaProdutoModel
                {
                    Id = p.Id,
                    Total = p.Total,
                    Desconto = p.Desconto,
                    Quantidade = p.Quantidade,
                    IdVenda = p.Vend!.Id,
                    IdProduto = p.Prod!.Id,
                    Produto = p.Prod!.Descricao
                };
                _vendaProduto.Add(produtos);
            }
            CarregaGridItensVenda();

        }

        private void CarregaGridItensVenda()

        {
            var source = new BindingSource();
            if (_vendaProduto == null)
            {
                _vendaProduto = new List<VendaProdutoModel>();
            }
            source.DataSource = _vendaProduto.ToArray();
            gridVendas.DataSource = source;           
            gridVendas.Columns["IdProduto"].HeaderText = "Id.Produto";
            gridVendas.Columns["ValorUnit"].DefaultCellStyle.Format = "C2";
            gridVendas.Columns["ValorUnit"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            gridVendas.Columns["Total"].DefaultCellStyle.Format = "C2";
            gridVendas.Columns["Total"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            gridVendas.Columns["Desconto"].DefaultCellStyle.Format = "C2";
            gridVendas.Columns["Desconto"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            gridVendas.Columns["Quantidade"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            if (ValidaItem())
            {
                var vendaProduto = new VendaProdutoModel();
                if (int.TryParse(cboProdutos.SelectedValue.ToString(), out var idProduto))
                {
                    var produto = _produtoService.GetById<Produto>(idProduto);
                    vendaProduto.IdProduto = produto.Id;
                    vendaProduto.Produto = produto.Descricao;
                }

                if (float.TryParse(txtValoru.Text, NumberStyles.Currency, CultureInfo.CurrentCulture.NumberFormat, out var valoru))
                {
                    vendaProduto.ValorUnit = valoru;
                }

                if (float.TryParse(txtDesconto.Text, NumberStyles.Currency, CultureInfo.CurrentCulture.NumberFormat, out var desconto))
                {
                    vendaProduto.Desconto = desconto;
                }

                if (int.TryParse(txtQnt.Text, out var qnt))
                {
                    vendaProduto.Quantidade = qnt;
                }

                vendaProduto.Total = (vendaProduto.Quantidade * vendaProduto.ValorUnit) - vendaProduto.Desconto;

                _vendaProduto.Add(vendaProduto);
                CalculaTotalVenda();
                CarregaGridItensVenda();
            }
        }

        private bool ValidaItem()
        {
            return true;
        }

        private void txtValor_Leave(object sender, EventArgs e)
        {
            if (double.TryParse(txtValoru.Text, out double value))
                txtValoru.Text = string.Format(CultureInfo.CurrentCulture, "{0:C2}", value);
            else
                txtValoru.Text = string.Empty;

            CalculaTotalItem();
        }

        private void CalculaTotalItem()
        {
            var convVlr = float.TryParse(txtValoru.Text, NumberStyles.Currency, CultureInfo.CurrentCulture.NumberFormat, out float valoru);
            var convQtd = int.TryParse(txtQnt.Text, out int qnt);
            var convDesc = float.TryParse(txtDesconto.Text, NumberStyles.Currency, CultureInfo.CurrentCulture.NumberFormat, out float desconto);
            if (convVlr && convQtd)
            {
                var valorTotal = (qnt * valoru) - desconto;
                txtTotalvenda.Text = string.Format(CultureInfo.CurrentCulture, "{0:C2}", valorTotal);
            }
        }

        private void CalculaTotalVenda()
        {
            lblTotal.Text = $"Valor Total: {string.Format(CultureInfo.CurrentCulture, "{0:C2}", _vendaProduto.Sum(x => x.Total))}";
            lblProdutos.Text = $"Qtd. Produtos: {_vendaProduto.Sum(x => x.Quantidade)}";
        }

        private void txtQuantidade_Leave(object sender, EventArgs e)
        {
            CalculaTotalItem();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void VendaCadastro_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void gridVendas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void lblTotal_Click(object sender, EventArgs e)
        {

        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {

        }

        private void gridVendas_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtId_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

