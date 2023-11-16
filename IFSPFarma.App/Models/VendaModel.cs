namespace IFSPFarma.App.Models
{
    public class VendaModel
    {
        public int Id { get; set; }
        public DateTime Data { get; set; }
        public int IdCliente { get; set; }
        public string Cliente { get; set; }
        public int IdFarmaceutico { get; set; }
        public string Farmaceutico { get; set; }
    }
}
