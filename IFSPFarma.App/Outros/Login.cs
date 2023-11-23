using IFSPFarma.App.Models;
using IFSPFarmacia.Domain.Base;
using IFSPFarmacia.Domain.Entities;
using IFSPFarma.Service.Validators;
using ReaLTaiizor.Forms;

namespace IFSPFarma.App.Outros
{
    public partial class Login : MaterialForm
    {
        public Login()
        {
            InitializeComponent();
        }

        private readonly IBaseService<Cliente> _clienteService;

        public Login(IBaseService<Cliente> clienteService)
        {
            _clienteService = clienteService;
            InitializeComponent();
#if DEBUG
            txtLogin.Text = @"admin";
            txtSenha.Text = @"admin";
#endif
        }

        private Cliente? ObterCliente(string login, string senha)
        {
            ChecaExistenciaDeClientesCadastrados();

            var cliente = _clienteService.Get<Cliente>().Where(x => x.Login == login).FirstOrDefault();
            if (cliente == null)
            {
                return null;
            }
            return cliente.Senha != senha ? null : cliente;
        }

        private void ChecaExistenciaDeClientesCadastrados()
        {
            var usuarios = _clienteService.Get<ClienteModel>().ToList();
            if (!usuarios.Any())
            {
                var cliente = new Cliente
                {                   
                    Nome = "Administrador",
                    Login = "admin",
                    Senha = "admin",
                    Email = "admin@mail.com"
                };
                _clienteService.Add<Cliente, Cliente, ClienteValidator>(cliente);
            }
        }

        private void materialButton2_Click(object sender, EventArgs e)
        {
            var cliente = ObterCliente(txtLogin.Text, txtSenha.Text);

            if (cliente == null)
            {
                MessageBox.Show("Usuário e/ou senha inválido(s)!", "IFSP Farma", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtLogin.Focus();
            }          
            else
            {              
                cliente = _clienteService.Update<Cliente, Cliente, ClienteValidator>(cliente);
                Principal.cliente = cliente;
                DialogResult = DialogResult.OK;
                Close();
            }
        }

        private void materialButton1_Click(object sender, EventArgs e)
        {

        }
    }
}
