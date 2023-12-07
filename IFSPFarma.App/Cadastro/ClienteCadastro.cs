using IFSPFarma.App;
using IFSPFarmacia.Domain.Base;
using IFSPFarmacia.Domain.Entities;
using IFSPFarma.Service.Validators;
using ReaLTaiizor.Controls;

namespace IFSPFarma.App.Cadastro
{
    public partial class ClienteCadastro : CadastroBase
    {

        private readonly IBaseService<Cliente> _clienteService;

        private List<Cliente>? clientes;

        public ClienteCadastro(IBaseService<Cliente> clienteService)
        {
            _clienteService = clienteService;
            InitializeComponent();
        }

        private void PreencheObjeto(Cliente cliente)
        {
            cliente.Nome = txtNome.Text;
            cliente.Senha = txtSenha.Text;
            cliente.Login = txtLogin.Text;
            cliente.Email = txtEmail.Text;
        }

        public ClienteCadastro()
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

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(@"Deseja realmente cancelar?", @"IFSP Store", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question)
                == DialogResult.Yes)
            {
                LimpaCampos();
                materialTabControl1.SelectedIndex = 1;
            }
        }


    }
}
