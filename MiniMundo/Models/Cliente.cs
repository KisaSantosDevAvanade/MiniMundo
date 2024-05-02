using System.Collections;
using System.ComponentModel.DataAnnotations;

namespace MiniMundo.Models
{
    public class Cliente
    {
        public int ClienteID { get; set; }
        [Display(Name = "Nome do Cliente")]
        [Required]
        public string? ClienteNome { get; set; }
        [DataType(DataType.Date)]
        public DateTime? DataFidelizacao { get; set; }
    }
}
