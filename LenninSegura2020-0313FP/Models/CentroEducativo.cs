using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace LenninSegura2020_0313FP.Models
{
    public class CentroEducativo
    {
        [Key]

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdCentro { get; set; }

        [Required]
        public string Nombre { get; set; }
        [Required]
        public string direccion { get; set; }

        [Required]
        public string director { get; set; }

        [Required]
        public string telefono { get; set; }

        [Required]
        public string correo { get; set; }
    }
}
