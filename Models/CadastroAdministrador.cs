using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace FocinhosFelizes.Models
{
    [Table("CadastroAdministrador")]
    public class CadastroAdministrador
    {
        [Column("Id")]
        [Display(Name = "Cód. Administrador")]
        public int Id { get; set; }

        [Column("NomeAdm")]
        [Display(Name = "Nome do Administrador")]
        public string NomeAdm { get; set; } = string.Empty;

        [Column("Cpf")]
        [Display(Name = "CPF do Administrador")]
        public string Cpf { get; set; } = string.Empty;

        [Column("Email")]
        [Display(Name = "Email")]
        public string Email { get; set; } = string.Empty;

        [Column("Telefone")]
        [Display(Name = "Telefone do Administrador")]
        public string Telefone { get; set; } = string.Empty;

        [Column("Senha")]
        [Display(Name = "Senha do Administrador")]
        public string Senha { get; set; } = string.Empty;
    }
}
