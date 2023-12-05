using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace LenninSegura2020_0313FP.Models
{
    public class Reinscripcion
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdReinscripcion { get; set; }

        [Required]
        public DateTime Fecha_Inscripcion { get; set; }
        [Required]
        public DateTime Fecha_Limite { get; set; }

        public int idcentro { get; set; }

        [Required]
        public int idcurso { get; set; }
    }
}
