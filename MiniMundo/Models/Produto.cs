using System.ComponentModel.DataAnnotations;

namespace MiniMundo.Models
{
    public class Produto
    {
        public int ProdutoID { get; set; }
        [Display(Name = "Nome do Produto")]
        [Required]
        public string? NomeProduto { get; set; }
        [DataType(DataType.Date)]
        public DateTime? DataCadastro { get; set; }
        public decimal? precoProduto { get; set; }
    }
}
