using IFSPFarmacia.Domain.Base;

namespace IFSPFarmacia.Domain.Entities
{
    public class Produto : BaseEntity<int>
    {
        public Produto()
        {

        }
        public Produto(int id, int quantidade, decimal valorunitario, decimal valortotal) : base(id)
        {
            quantidade = quantidade;
            valorUnitario = valorunitario;
            valorTotal = valortotal;
        }
        public int Quantidade { get; set; }
        public decimal valorUnitario { get; set; }
        public decimal valorTotal { get; set; }
    }
}