using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace LenninSegura2020_0313FP.Models;

public partial class Estudiante
{
    [Key]
    public int ID { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string Nombre { get; set; } = null!;

    [StringLength(100)]
    [Unicode(false)]
    public string Apellido { get; set; } = null!;

    public DateOnly FechaNacimiento { get; set; }

    [Unicode(false)]
    public string? Direcion { get; set; }

    [StringLength(50)]
    public string? Email { get; set; }

    [StringLength(50)]
    public string NIE { get; set; } = null!;
}
