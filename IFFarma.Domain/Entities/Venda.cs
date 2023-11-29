using IFSPFarmacia.Domain.Base;

namespace IFSPFarmacia.Domain.Entities
{
    public class Venda : BaseEntity<int>
    {
        public Venda()
        {
            Produtos = new List<VendaProduto>();
        }
        public Venda(int id,String descricao, DateTime data, Cliente client, Farmaceutico farma, List<VendaProduto> produtos,double totalvenda) : base(id)
        {
            Descricao = descricao;
            Data = data;
            Client = client;
            Farma = farma;
            Produtos = produtos;
            TotalVenda = totalvenda;
        }
        public DateTime Data { get; set; }
        public String Descricao { get; set; }
        public Cliente Client { get; set; }
        public Farmaceutico Farma { get; set; }
        public List<VendaProduto> Produtos { get; set; }
        public Double TotalVenda { get; set; }
    }
}