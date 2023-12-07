using IFSPFarmacia.Domain.Entities;

namespace IFSPFarma.App.Models
{
    public class VendaProdutoModel
    {
        public int Id { get; set; }
        public double Total { get; set; }
        public double ValorUnit { get; set; }
        public double Desconto { get; set; }
        public int Quantidade { get; set; }
        public int IdVenda { get; set; }
        public string Venda { get; set; }
        public int IdProduto { get; set; }
        public string Produto { get; set; }
    }
}
