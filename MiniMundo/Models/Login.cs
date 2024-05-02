using System.ComponentModel.DataAnnotations;

namespace MiniMundo.Models
{
    public class Login
    {

        public int? LoginID { get; set; }

        [Display(Name = "Email")]
        [Required]
        public string? Email { get; set; }

        [StringLength(10, MinimumLength = 4, ErrorMessage = "Máximo de 10, mínimo de 4 caracteres.")]
        public string? Senha { get; set; }
    }
}
