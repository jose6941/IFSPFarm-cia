using IFSPFarma.App.Cadastro;
using IFSPFarma.App.Infra;
using IFSPFarma.App.Outros;
using IFSPFarmacia.Domain.Entities;
using Microsoft.Extensions.DependencyInjection;
using ReaLTaiizor.Forms;
using System.Security.Policy;
namespace IFSPFarma.App
{
    public partial class Principal : MaterialForm
    {

        public static Cliente cliente { get; set; }
        public Principal()
        {
            InitializeComponent();
        }

        private void CarregaLogin()
        {
            var login = ConfigDl.ServicesProvider!.GetService<Login>();
            if (login != null && !login.IsDisposed)
            {
                if (login.ShowDialog() != DialogResult.OK)
                {
                    Environment.Exit(0);
                }
            }
        }

        private void FormPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.ApplicationExitCall)
            {
                e.Cancel = true;
            }

        }

        private void Exibeformulario<TFormlario>() where TFormlario : Form
        {
            var cad = ConfigDl.ServicesProvider!.GetService<TFormlario>();
            if (cad != null && !cad.IsDisposed)
            {
                cad.MdiParent = this;
                cad.Show();
            }
        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Exibeformulario<ClienteCadastro>();
        }

        private void farmaceuticoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Exibeformulario<FarmaceuticoCadastro>();
        }

        private void fornecedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Exibeformulario<FornecedorCadastro>();
        }

        private void produtoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Exibeformulario<ProdutoCadastro>();
        }

        private void vendaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Exibeformulario<VendaCadastro>();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void remédioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Exibeformulario<RemedioCadastro>();
        }

        private void Principal_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }
    }
}
