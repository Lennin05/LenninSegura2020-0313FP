using LenninSegura2020_0313FP.Datos;
using LenninSegura2020_0313FP.Models;
using LenninSegura2020_0313FP.VM;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace LenninSegura2020_0313FP.Controllers
{
    public class AsignaturaController : Controller
    {

        //contexto
        private readonly ApplicationDbContext _context;

        public AsignaturaController(ApplicationDbContext context)
        {
            _context = context;
        }
        // GET: EstudianteController
        // GET: EstudianteController
        public async Task<IActionResult> Index()
        {
            AsignaturaMaestroVM asignaturaMaestro = new AsignaturaMaestroVM();
            asignaturaMaestro.ListaMaestro = (IEnumerable<SelectList>)_context.Maestros.Select(i => new SelectListItem
            {
                Text = i.Nombre,
             Value = i.ID.ToString(),
            });
            return View(asignaturaMaestro);
        }

        // GET: EstudianteController/Details/5
        public IActionResult Details(int id)
        {
            return View();
        }

        // GET: EstudianteController/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: EstudianteController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]

        public async Task<IActionResult> Create(Asignatura Asignaturas)
        {


            _context.Asignaturas.Add(Asignaturas);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");

        }

        // GET: EstudianteController/Edit/5
        [HttpGet]
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            // Verifica si el estudiante existe en la base de datos
            var Asignatura = await _context.Asignaturas.FindAsync(id);

            if (Asignatura == null)
            {
                return NotFound();
            }


            return View(Asignatura);
        }

        // POST: EstudianteController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit(Asignatura Asignaturas)
        {
            if (ModelState.IsValid)
            {
                _context.Update(Asignaturas);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(Asignaturas);
        }

        // GET: EstudianteController/Delete/5
        [HttpGet]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            // Verifica si el estudiante existe en la base de datos
            var Asignatura = await _context.Estudiantes.FindAsync(id);

            if (Asignatura == null)
            {
                return NotFound();
            }


            return View(Asignatura);
        }

        // POST: EstudianteController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Delete(Asignatura Asignaturas)
        {
            if (ModelState.IsValid)
            {
                _context.Remove(Asignaturas);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(Asignaturas);
        }
    }
}
