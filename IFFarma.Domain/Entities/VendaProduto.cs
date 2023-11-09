using IFSPFarmacia.Domain.Base;

namespace IFSPFarmacia.Domain.Entities
{
    public class VendaProduto : BaseEntity<int>
    {
        public VendaProduto()
        {

        }
        public VendaProduto(int id, double total, double desconto, int quantidade, Venda vend, Produto prod) : base(id)
        {
            Total = total;
            Desconto = desconto;
            Quantidade = quantidade;
            Vend = vend;
            Prod = prod;
        }
        public double Total { get; set; }
        public double Desconto { get; set; }
        public int Quantidade { get; set; }
        public Venda Vend { get; set; }
        public Produto Prod { get; set; }
    }
}