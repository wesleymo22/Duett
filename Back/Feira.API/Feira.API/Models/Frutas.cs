using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Feira.API.Models
{
    public class Frutas
    {
        [Key]
        public int FrutaId { get; set; }
        [Display(Name = "Frutas")]
        public string Fruta { get; set; }

        [Display(Name = "Valor A")]
        public int ValorA { get; set; }

        [Display(Name = "Valor B")]
        public int ValorB { get; set; }
    }
}
