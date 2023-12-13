using IFSPFarmacia.Domain.Base;

namespace IFSPFarmacia.Domain.Entities
{
    public class Fornecedor : BaseEntity<int>
    {
        public Fornecedor()
        {

        }
        public Fornecedor(int id, string nome, double cnpj, string razaosocial) : base(id)
        {
            Nome = nome;
            Cnpj = cnpj;
            Razaosocial = razaosocial;        
        }
        public string? Nome { get; set; }
        public double? Cnpj { get; set; }
        public string? Razaosocial { get; set; }       
    }
}