using System.ComponentModel.DataAnnotations;

namespace MiniMundo.Models
{
    public class Venda
    {
        public int VendaID { get; set; }
        [DataType(DataType.Date)]
        public DateTime? DataVenda { get; set; }
        [Display(Name = "ID Do Administrador")]
        [Required]
        public int AdministradorId { get; set; }
        [Display(Name = "Administrador")]
        public string? NomeAdministrador { get; set; }
        [Display(Name = "ID Do Vendedor")]
        [Required]
        public int VendedorId { get; set; }
        public string? NomeVendedor { get; set; }
        [Display(Name = "ID Do Cliente")]
        [Required]
        public int ClienteId { get; set; }
        public string? NomeCliente { get; set; }
        [Display(Name = "Valor total da compra")]
        [Required]
        public decimal? ValorTotal { get; set; }

    }
}
