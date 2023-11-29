using IFSPFarmacia.Domain.Base;

namespace IFSPFarmacia.Domain.Entities
{
    public class Produto : BaseEntity<int>
    {
        public Produto()
        {

        }
        public Produto(int id,string descricao, int quantidade, double valorunitario, double valortotal, Fornecedor forn, Remedio remed) : base(id)
        {
            Descricao = descricao;
            Quantidade = quantidade;
            ValorUnitario = valorunitario;
            ValorTotal = valortotal;
            Forn = forn;
            Remed = remed;
        }
        public int Quantidade { get; set; }
        public string Descricao { get; set; }
        public double ValorUnitario { get; set; }
        public double ValorTotal { get; set; }
        public Fornecedor Forn { get; set; }
        public Remedio Remed { get; set; }
    }
}