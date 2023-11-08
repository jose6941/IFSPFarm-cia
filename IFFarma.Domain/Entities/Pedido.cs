using IFSPFarmacia.Domain.Base;

namespace IFSPFarmacia.Domain.Entities
{
    public class Pedido : BaseEntity<int>
    {
        public Pedido()
        {

        }
        public Pedido(int id, double total, double desconto, int idvenda, int idproduto) : base(id)
        {
            Total = total;
            Desconto = desconto;
            Idvenda = idvenda;
            Idproduto = idproduto;
        }
        public double Total { get; set; }
        public double Desconto { get; set; }
        public int Idvenda { get; set; }
        public int Idproduto { get; set; }
    }
}