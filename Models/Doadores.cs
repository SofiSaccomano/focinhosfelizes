using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FocinhosFelizes.Models
{
    [Table("Doadores")]
    public class Doadores
    {
        [Column("Id")]
        [Display(Name = "Cód. Doador")]
        public int Id { get; set; }

        [Column("NomeDoador")]
        [Display(Name = "Nome do Doador")]
        public string NomeDoador { get; set; } = string.Empty;

        [Column("Cpf")]
        [Display(Name = "CPF do Doador")]
        public string Cpf { get; set; } = string.Empty;

        [Column("Telefone")]
        [Display(Name = "Telefone do Administrador")]
        public string Telefone { get; set; } = string.Empty;
    }
}
