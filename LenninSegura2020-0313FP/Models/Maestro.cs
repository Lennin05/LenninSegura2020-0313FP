using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace LenninSegura2020_0313FP.Models;

public partial class Maestro
{
    [Key]
    public int ID { get; set; }

    [StringLength(50)]
    public string Nombre { get; set; } = null!;

    [StringLength(100)]
    public string Apellido { get; set; } = null!;

    [StringLength(50)]
    public string Documento { get; set; } = null!;

    [StringLength(50)]
    public string? Telefono { get; set; }

    [StringLength(50)]
    public string? Direccion { get; set; }

    [StringLength(50)]
    public string Area { get; set; } = null!;

    [StringLength(50)]
    public string? Email { get; set; }
}
