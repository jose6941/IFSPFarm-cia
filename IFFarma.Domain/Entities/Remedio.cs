using IFSPFarmacia.Domain.Base;

namespace IFSPFarmacia.Domain.Entities
{
    public class Remedio : BaseEntity<int>
    {
        public Remedio()
        {

        }
        public Remedio(int id, string nome) : base(id)
        {
            Nome = nome;
        }
        public string? Nome { get; set; }       
    }
}