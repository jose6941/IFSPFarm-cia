using IFSPFarma.App;
using IFSPFarmacia.Domain.Base;
using IFSPFarmacia.Domain.Entities;
using IFSPFarma.Service.Validators;
using ReaLTaiizor.Controls;

namespace IFSPFarma.App.Cadastro
{
    public partial class FarmaceuticoCadastro : CadastroBase
    {

        private readonly IBaseService<Farmaceutico> _farmaceuticoService;

        private List<Farmaceutico>? farmaceuticos;

        public FarmaceuticoCadastro(IBaseService<Farmaceutico> farmaceuticoService)
        {
            _farmaceuticoService = farmaceuticoService;
            InitializeComponent();
        }

        private void PreencheObjeto(Farmaceutico farmaceutico)
        {
            farmaceutico.Nome = txtNome.Text;
            farmaceutico.Endereco = txtEndereço.Text;
            farmaceutico.Idade = txtIdade.ToString;
        }

        public FarmaceuticoCadastro()
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
                        var farmaceutico = _farmaceuticoService.GetById<Farmaceutico>(id);
                        PreencheObjeto(farmaceutico);
                        farmaceutico = _farmaceuticoService.Update<Farmaceutico, Farmaceutico, FarmaceuticoValidator>(farmaceutico);
                    }

                }
                else
                {
                    var farmaceutico = new Farmaceutico();
                    PreencheObjeto(farmaceutico);
                    _farmaceuticoService.Add<Farmaceutico, Farmaceutico, FarmaceuticoValidator>(farmaceutico);
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
                _farmaceuticoService.Delete(id);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, @"IFSP Farma", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected override void CarregaGrid()
        {
            farmaceuticos = _farmaceuticoService.Get<Farmaceutico>().ToList();
            gridConsualta.DataSource = farmaceuticos;
            gridConsualta.Columns["Nome"]!.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        protected override void CarregaRegistro(DataGridViewRow? linha)
        {
            txtId.Text = linha?.Cells["Id"].Value.ToString();
            txtNome.Text = linha?.Cells["Nome"].Value.ToString();
            txtEndereço.Text = linha?.Cells["Endereço"].Value.ToString();
            txtIdade.Text = linha?.Cells["Idade"].Value.ToString();         
        }

    }
}
