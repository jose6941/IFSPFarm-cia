using IFSPFarmacia.Domain.Base;

namespace IFSPFarmacia.Domain.Entities
{
    public class Cliente : BaseEntity<int>
    {
        public Cliente()
        {

        }
        public Cliente(int id, string nome, string senha, string login, string email) : base(id)
        {
            Nome = nome;
            Senha = senha;
            Login = login;
            Email = email;
        }
        public string? Nome { get; set; }
        public string? Senha { get; set; }
        public string? Login { get; set; }
        public string? Email { get; set; }
    }
}