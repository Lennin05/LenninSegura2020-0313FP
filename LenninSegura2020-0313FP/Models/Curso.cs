using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace LenninSegura2020_0313FP.Models;

public partial class Curso
{
    [Key]
    public int ID { get; set; }

    [StringLength(100)]
    public string Cursos { get; set; } = null!;
}
