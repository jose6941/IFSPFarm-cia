using IFSPFarma.App;
using IFSPFarma.App.Models;
using IFSPFarmacia.Domain.Base;
using IFSPFarmacia.Domain.Entities;
using IFSPFarma.Service.Validators;

namespace IFSPFarma.App.Cadastro
{
    public partial class ProdutoCadastro : CadastroBase
    {
        private readonly IBaseService<Produto> _produtoService;
        private readonly IBaseService<Fornecedor> _fornecedorService;
        private readonly IBaseService<Remedio> _remedioService;

        private List<ProdutoModel>? produtos;
        public ProdutoCadastro(IBaseService<Produto> produtoService,
                               IBaseService<Fornecedor> fornecedorService,
                               IBaseService<Remedio> remedioService)
        {
            _produtoService = produtoService;
            _fornecedorService = fornecedorService;
            _remedioService = remedioService;
            InitializeComponent();
            CarregarCombo();
        }

        private void CarregarCombo()
        {
            cboTipo.ValueMember = "Id";
            cboTipo.DisplayMember = "Nome";
            cboTipo.DataSource = _remedioService.Get<Remedio>().ToList();

            cboFornecedor.ValueMember = "Id";
            cboFornecedor.DisplayMember = "Nome";
            cboFornecedor.DataSource = _fornecedorService.Get<Fornecedor>().ToList();
        }

        private void PreencheObjeto(Produto produto)
        {
            if (double.TryParse(txtValoru.Text, out var valoru))
            {
                produto.ValorUnitario = valoru;
            }
            if (int.TryParse(txtQnt.Text, out var qnt))
            {
                produto.Quantidade = qnt;
            }

            produto.Descricao = txtNome.Text;

            if (int.TryParse(cboFornecedor.SelectedValue.ToString(), out var idFornecedor))
            {
                var fornecedor = _fornecedorService.GetById<Fornecedor>(idFornecedor);
                produto.Forn = fornecedor;
            }
            if (int.TryParse(cboTipo.SelectedValue.ToString(), out var idRemedio))
            {
                var remedio = _remedioService.GetById<Remedio>(idRemedio);
                produto.Remed = remedio;
            }
        }

        protected override void Salvar()
        {
            try
            {
                if (IsAlteracao)
                {
                    if (int.TryParse(txtId.Text, out var id))
                    {
                        var produto = _produtoService.GetById<Produto>(id);
                        PreencheObjeto(produto);
                        produto = _produtoService.Update<Produto, Produto, ProdutoValidator>(produto);
                    }

                }
                else
                {
                    var produto = new Produto();
                    PreencheObjeto(produto);
                    _produtoService.Add<Produto, Produto, ProdutoValidator>(produto);

                }

                materialTabControl1.SelectedIndex = 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, @"IFSP Store", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected override void Deletar(int id)
        {
            try
            {
                _produtoService.Delete(id);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, @"IFSP Store", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected override void CarregaGrid()
        {
            produtos = _produtoService.Get<ProdutoModel>(new[] { "Fornecedor" }).ToList();
            gridConsualta.DataSource = produtos;
            gridConsualta.Columns["IdFornecedor"]!.Visible = false;

            produtos = _produtoService.Get<ProdutoModel>(new[] { "Remedio" }).ToList();
            gridConsualta.DataSource = produtos;
            gridConsualta.Columns["IdRemedio"]!.Visible = false;
        }

        protected override void CarregaRegistro(DataGridViewRow? linha)
        {
            txtId.Text = linha?.Cells["Id"].Value.ToString();
            txtValoru.Text = linha?.Cells["Valor unitário"].Value.ToString();
            txtQnt.Text = linha?.Cells["Quantidade"].Value.ToString();
            txtNome.Text = linha?.Cells["Nome"].Value.ToString();
            cboFornecedor.SelectedValue = linha?.Cells["IdFornecedor"].Value;
            cboTipo.SelectedValue = linha?.Cells["IdRemedio"].Value;
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }
    }
}

