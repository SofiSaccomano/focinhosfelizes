using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FocinhosFelizes.Models
{
    [Table("Estoques")]
    public class Estoques
    {
        [Column("Id")]
        [Display(Name = "Cód. Produto")]
        public int Id { get; set; }

        [ForeignKey("ProdutosId")]
        [Display(Name = "Produtos")]
        public string ProdutosId { get; set; } = string.Empty;
        public Produtos? Produtos { get; set; }

        [Column("QtdEstoque")]
        [Display(Name = "Qtd. Estoque")]
        public int QtdEstoque { get; set; }

    }
}
