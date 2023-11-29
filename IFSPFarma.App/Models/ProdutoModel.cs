namespace IFSPFarma.App.Models
{
    public class ProdutoModel
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public int Quantidade { get; set; }
        public double ValorUnitario { get; set; }
        public double ValorTotal { get; set; }
        public int IdFornecedor { get; set; }
        public string Fornecedor { get; set; }
        public int IdRemedio { get; set; }
        public string Remedio { get; set; }
    }
}
