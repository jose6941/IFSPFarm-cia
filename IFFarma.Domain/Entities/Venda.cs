using IFSPFarmacia.Domain.Base;

namespace IFSPFarmacia.Domain.Entities
{
    public class Venda : BaseEntity<int>
    {
        public Venda()
        {

        }
        public Venda(int id, DateTime data, Cliente client, Farmaceutico farma) : base(id)
        {
            Data = data;
            Client = client;
            Farma = farma;
        }
        public DateTime Data { get; set; }
        public Cliente Client { get; set; }
        public Farmaceutico Farma { get; set; }
    }
}