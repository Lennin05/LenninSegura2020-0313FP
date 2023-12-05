using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace LenninSegura2020_0313FP.Models
{
    public class Inscripcion
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdInscripcion { get; set; }

        [Required]
        public DateTime Fecha_Inscripcion { get; set; }
        [Required]
        public DateTime Fecha_Limite { get; set; }


        [ForeignKey("Curso")]
        public int? cursoID { get; set; }
        public Curso? centro;

        [ForeignKey("Estudiante")]
        public int? estudianteID { get; set; }
        public Estudiante? estudiante { get; set; }
    }
}
