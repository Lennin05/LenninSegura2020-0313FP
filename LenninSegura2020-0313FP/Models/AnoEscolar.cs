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

    [Column("AnoEscolar")]
    [StringLength(50)]
    [Unicode(false)]
    public string AnoEscolar1 { get; set; } = null!;
}
