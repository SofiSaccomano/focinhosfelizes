using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FocinhosFelizes.Models
{
    [Table("Categorias")]
    public class Categorias
    {
        [Column("Id")]
        [Display(Name = "Cód. Categoria")]
        public int Id { get; set; }

        [Column("TipoCategoria")]
        [Display(Name = "Tipo da Categoria")]
        public string TipoCategoria { get; set; } = string.Empty;

        [Column("DescricaoCategoria")]
        [Display(Name = "Descrição da Categoria")]
        public string DescricaoCategoria { get; set; } = string.Empty;

    }
}
