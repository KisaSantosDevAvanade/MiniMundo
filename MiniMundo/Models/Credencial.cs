using System.ComponentModel.DataAnnotations;

namespace MiniMundo.Models
{
    public class Credencial
    {
        public int CredencialID { get; set; }
        [Display(Name = "Nome do Administrador")]
        [Required]

        public string? NomeAdm { get; set; }
        [Display(Name = "Nível de acesso")]
        [Required]

        public string? NivelAcesso { get; set; }
    }
}
