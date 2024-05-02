using System.ComponentModel.DataAnnotations;

namespace MiniMundo.Models
{
    public class Funcionario
    {
        public int FuncionarioID { get; set; }

        [Display(Name = "ID Do Administrador/Supervisor")]
        [Required]
        public int AdmninistradorId { get; set; } // ID do nivel de acesso de admnistrador
        [Display(Name = "Nome do Funcionario")]
        [Required]
        public string? FuncionarioNome { get; set; }

        [DataType(DataType.Date)]
        [Required]
        public DateTime? DataContratacao { get; set; }
    }
}
