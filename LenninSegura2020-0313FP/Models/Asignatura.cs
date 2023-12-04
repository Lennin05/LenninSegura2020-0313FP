using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace LenninSegura2020_0313FP.Models;

public partial class Asignatura
{
    [Key]
    public int ID { get; set; }

    [Column("Asignatura")]
    [Unicode(false)]
    public string Asignatura1 { get; set; } = null!;

    [StringLength(50)]
    [Unicode(false)]
    public string? CargaHoraria { get; set; }
}
