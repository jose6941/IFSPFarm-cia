using IFSPFarmacia.Domain.Base;

namespace IFSPFarmacia.Domain.Entities
{
    public class Venda : BaseEntity<int>
    {
        public Venda()
        {

        }
        public Venda(int id, DateTime data, string codigo) : base(id)
        {
            Data = data;
            Codigo = codigo;
        }
        public DateTime Data { get; set; }
        public string? Codigo { get; set; }       
    }
}