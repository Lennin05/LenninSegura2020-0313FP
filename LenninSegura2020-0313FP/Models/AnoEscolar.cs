using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace LenninSegura2020_0313FP.Models;

[Table("AnoEscolar")]
public partial class AnoEscolar
{
    [Key]
    public int ID { get; set; }


    public string anoEscolar { get; set; } = null!;

    //relaciones
    public List<Curso> cursos { get; set; }
}
