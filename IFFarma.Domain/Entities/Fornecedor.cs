using IFSPFarmacia.Domain.Base;

namespace IFSPFarmacia.Domain.Entities
{
    public class Fornecedor : BaseEntity<int>
    {
        public Fornecedor()
        {

        }
        public Fornecedor(int id, string nome, string cnpj, string razaosocial) : base(id)
        {
            Nome = nome;
            Cnpj = cnpj;
            Razaosocial = razaosocial;        
        }
        public string? Nome { get; set; }
        public string? Cnpj { get; set; }
        public string? Razaosocial { get; set; }       
    }
}