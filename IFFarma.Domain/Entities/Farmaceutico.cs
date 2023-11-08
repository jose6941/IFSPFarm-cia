using IFSPFarmacia.Domain.Base;

namespace IFSPFarmacia.Domain.Entities
{
    public class Farmaceutico : BaseEntity<int>
    {
        public Farmaceutico()
        {

        }
        public Farmaceutico(int id, string nome, string endereco, int idade) : base(id)
        {
            Nome = nome;
            Endereco = endereco;
            Idade = idade;
        }
        public string? Nome { get; set; }
        public string? Endereco { get; set; }
        public int Idade { get; set; }
    }
}