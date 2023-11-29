using IFSPFarma.App;
using IFSPFarmacia.Domain.Base;
using IFSPFarmacia.Domain.Entities;
using IFSPFarma.Service.Validators;
using ReaLTaiizor.Controls;

namespace IFSPFarma.App.Cadastro
{
    public partial class FornecedorCadastro : CadastroBase
    {

        private readonly IBaseService<Fornecedor> _fornecedorService;

        private List<Fornecedor>? fornecedores;

        public FornecedorCadastro(IBaseService<Fornecedor> fornecedorService)
        {
            _fornecedorService = fornecedorService;
            InitializeComponent();
        }

        private void PreencheObjeto(Fornecedor fornecedor)
        {
            fornecedor.Nome = txtNome.Text;
            fornecedor.Cnpj = txtCnpj.Text;
            fornecedor.Razaosocial = txtRazaosocial.Text;
        }

        public FornecedorCadastro()
        {
            InitializeComponent();
        }

        protected override void Salvar()
        {
            try
            {
                if (IsAlteracao)
                {

                    if (int.TryParse(txtId.Text, out var id))
                    {
                        var fornecedor = _fornecedorService.GetById<Fornecedor>(id);
                        PreencheObjeto(fornecedor);
                        fornecedor = _fornecedorService.Update<Fornecedor, Fornecedor, FornecedorValidator>(fornecedor);
                    }

                }
                else
                {
                    var fornecedor = new Fornecedor();
                    PreencheObjeto(fornecedor);
                    _fornecedorService.Add<Fornecedor, Fornecedor, FornecedorValidator>(fornecedor);
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
                _fornecedorService.Delete(id);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, @"IFSP Farma", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected override void CarregaGrid()
        {
            fornecedores = _fornecedorService.Get<Fornecedor>().ToList();
            gridConsualta.DataSource = fornecedores;
            gridConsualta.Columns["Nome"]!.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        protected override void CarregaRegistro(DataGridViewRow? linha)
        {
            txtId.Text = linha?.Cells["Id"].Value.ToString();
            txtNome.Text = linha?.Cells["Nome"].Value.ToString();
            txtCnpj.Text = linha?.Cells["Cnpj"].Value.ToString();
            txtRazaosocial.Text = linha?.Cells["Razão social"].Value.ToString();
        }

    }
}
