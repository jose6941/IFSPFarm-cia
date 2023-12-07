using IFSPFarma.App;
using IFSPFarmacia.Domain.Base;
using IFSPFarmacia.Domain.Entities;
using IFSPFarma.Service.Validators;
using ReaLTaiizor.Controls;
using IFSPFarma.App.Models;

namespace IFSPFarma.App.Cadastro
{
    public partial class RemedioCadastro : CadastroBase
    {
        private readonly IBaseService<Remedio> _remedioService;
        private List<RemedioModel>? remedios;
        public RemedioCadastro(IBaseService<Remedio> remedioService)
        {
            _remedioService = remedioService;
            InitializeComponent();
        }

        private void PreencheObjeto(Remedio remedio)
        {
            remedio.Nome = txtTipo.Text;
        }

        protected override void Salvar()
        {
            try
            {
                if (IsAlteracao)
                {
                    if (int.TryParse(txtId.Text, out var id))
                    {
                        var remedio = _remedioService.GetById<Remedio>(id);
                        PreencheObjeto(remedio);
                        remedio = _remedioService.Update<Remedio, Remedio, RemedioValidator>(remedio);
                    }

                }
                else
                {
                    var remedio = new Remedio();
                    PreencheObjeto(remedio);
                    _remedioService.Add<Remedio, Remedio, RemedioValidator>(remedio);

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
                _remedioService.Delete(id);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, @"IFSP Store", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected override void CarregaGrid()
        {
            remedios = _remedioService.Get<RemedioModel>(new[] { "Remedio" }).ToList();
            gridConsualta.DataSource = remedios;
            gridConsualta.Columns["Nome"]!.Visible = false;
        }

        protected override void CarregaRegistro(DataGridViewRow? linha)
        {
            txtId.Text = linha?.Cells["Id"].Value.ToString();
            txtTipo.Text = linha?.Cells["Tipo"].Value.ToString();
        }

        private void RemedioCadastro_Load(object sender, EventArgs e)
        {

        }
    }
}
