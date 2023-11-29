using IFSPFarma.App;
using IFSPFarmacia.Domain.Base;
using IFSPFarmacia.Domain.Entities;
using IFSPFarma.Service.Validators;
using ReaLTaiizor.Controls;
using IFSPFarma.App.Models;
using System.Xml.Schema;
using System.Globalization;

namespace IFSPFarma.App.Cadastro
{
    public partial class VendaCadastro : CadastroBase
    {
        private List<VendaProdutoModel> _vendaProduto;
        private readonly IBaseService<Venda> _vendaService;
        private readonly IBaseService<Farmaceutico> _farmaceuticoService;
        private readonly IBaseService<Cliente> _clienteService;
        private readonly IBaseService<Produto> _produtoService;

        private List<VendaModel>? vendas;

        public VendaCadastro()
        {
            InitializeComponent();
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
            cboProdutos.DisplayMember = "Nome";
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
                venda.Client = cliente;
            }

            if (int.TryParse(cboFarmaceutico.SelectedValue.ToString(), out var idFarmaceutico))
            {
                var farmaceutico = _clienteService.GetById<Farmaceutico>(idFarmaceutico);
                venda.Farma = farmaceutico;
            }
            venda.TotalVenda = _vendaProduto.Sum(x => x.Total);

            foreach (var p in _vendaProduto)
            {
                var produtos = new VendaProduto
                {
                    Total = p.Total,
                    Desconto = p.Desconto,
                    Quantidade = p.Quantidade,
                    Vend = _vendaService.GetById<Venda>(p.IdVenda),
                    Prod = _produtoService.GetById<Produto>(p.IdProduto)
                };

                venda.Produtos.Add(produtos);
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
            gridConsualta.Columns["ValorTotal"].DefaultCellStyle.Format = "C2";
            gridConsualta.Columns["ValorTotal"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
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
                    Venda = p.Vend!.Descricao,
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
            gridConsualta.DataSource = source;
            gridConsualta.Columns["Id"].Visible = false;
            gridConsualta.Columns["IdProduto"].HeaderText = "Id.Produto";
            gridConsualta.Columns["ValorUnitario"].DefaultCellStyle.Format = "C2";
            gridConsualta.Columns["ValorUnitario"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            gridConsualta.Columns["ValorTotal"].DefaultCellStyle.Format = "C2";
            gridConsualta.Columns["ValorTotal"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            gridConsualta.Columns["Quantidade"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
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

            }
        }

        private bool ValidaItem()
        {
            return true;
        }
    }
}

