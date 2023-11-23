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

        private List<Produto>? produtos;

        public ProdutoCadastro(IBaseService<Produto> produtoService, IBaseService<Fornecedor> fornecedorService)
        {
            _produtoService = produtoService;
            _fornecedorService = fornecedorService;
            InitializeComponent();
        }

        private void PreencheObjeto(Produto produto)
        {
            produto.Nome = txtNome.Text;
            if (float.TryParse(txtPreco.Text, out var preco))
            {
                produto.Preco = preco;
            }

            if (DateTime.TryParse(txtDataCompra.Text, out var dataCompra))
            {
                produto.DataCompra = dataCompra;
            }
            produto.UnidadeVenda = txtUnidadeVenda.Text;

            if (int.TryParse(cboGrupo.SelectedValue.ToString(), out var idGrupo))
            {
                var grupo = _grupoService.GetById<Grupo>(idGrupo);
                produto.Grupo = grupo;
                //_produtoService.AttachObject(grupo);
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
                        var cliente = _clienteService.GetById<Cliente>(id);
                        PreencheObjeto(cliente);
                        cliente = _clienteService.Update<Cliente, Cliente, ClienteValidator>(cliente);
                    }

                }
                else
                {
                    var cliente = new Cliente();
                    PreencheObjeto(cliente);
                    _clienteService.Add<Cliente, Cliente, ClienteValidator>(cliente);
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
                _clienteService.Delete(id);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, @"IFSP Farma", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected override void CarregaGrid()
        {
            clientes = _clienteService.Get<Cliente>().ToList();
            gridConsualta.DataSource = clientes;
            gridConsualta.Columns["Nome"]!.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        protected override void CarregaRegistro(DataGridViewRow? linha)
        {
            txtId.Text = linha?.Cells["Id"].Value.ToString();
            txtNome.Text = linha?.Cells["Nome"].Value.ToString();
            txtSenha.Text = linha?.Cells["Senha"].Value.ToString();
            txtLogin.Text = linha?.Cells["Login"].Value.ToString();
            txtEmail.Text = linha?.Cells["Email"].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

    }
}
