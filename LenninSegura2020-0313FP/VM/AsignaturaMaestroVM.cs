using LenninSegura2020_0313FP.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace LenninSegura2020_0313FP.VM
{
    public class AsignaturaMaestroVM
    {

        public Asignatura asignatura {  get; set; }
        public IEnumerable<SelectList>ListaMaestro { get; set; }
    }
}
