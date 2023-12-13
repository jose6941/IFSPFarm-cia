using IFSPFarmacia.Domain.Base;

namespace IFSPFarmacia.Domain.Entities
{
    public class Produto : BaseEntity<int>
    {
        public Produto()
        {

        }

        public Produto(int id,string descricao, Fornecedor fornecedor, Remedio remedio) : base(id)
        {
            Descricao = descricao;                  
            Fornecedor = fornecedor;
            Remedio = remedio;
        }       
        public string Descricao { get; set; }      
        public Fornecedor Fornecedor { get; set; }
        public Remedio Remedio { get; set; }
    }
}