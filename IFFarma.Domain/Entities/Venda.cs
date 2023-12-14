using IFSPFarmacia.Domain.Base;

namespace IFSPFarmacia.Domain.Entities
{
    public class Venda : BaseEntity<int>
    {
        public Venda()
        {
            Produtos = new List<VendaProduto>();
        }
        public Venda(int id, DateTime data, Cliente client, Farmaceutico farma, List<VendaProduto> produtos,double totalvenda) : base(id)
        {          
            Data = data;
            Cliente = client;
            Farmaceutico = farma;
            Produtos = produtos;
            TotalVenda = totalvenda;
        }
        public DateTime Data { get; set; }       
        public virtual Cliente Cliente { get; set; }
        public virtual Farmaceutico Farmaceutico { get; set; }
        public virtual List<VendaProduto> Produtos { get; set; }
        public Double TotalVenda { get; set; }
    }
}