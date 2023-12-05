using LenninSegura2020_0313FP.Datos;
using LenninSegura2020_0313FP.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace LenninSegura2020_0313FP.Controllers
{
    public class InscripcionController : Controller
    {

        //contexto
        private readonly ApplicationDbContext _context;

        public InscripcionController(ApplicationDbContext context)
        {
            _context = context;
        }
        // GET: EstudianteController
        // GET: EstudianteController
        public async Task<IActionResult> Index()
        {
            var Inscripcion = _context.Inscripciones;
            return View(await Inscripcion.ToListAsync());
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

        public async Task<IActionResult> Create(Inscripcion Inscripciones)
        {


            _context.Inscripciones.Add(Inscripciones);
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
            var Inscripcion = await _context.Inscripciones.FindAsync(id);

            if (Inscripcion == null)
            {
                return NotFound();
            }


            return View(Inscripcion);
        }

        // POST: EstudianteController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit(Inscripcion Inscripciones)
        {
            if (ModelState.IsValid)
            {
                _context.Update(Inscripciones);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(Inscripciones);
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
            var Inscripcion = await _context.Inscripciones.FindAsync(id);

            if (Inscripcion == null)
            {
                return NotFound();
            }


            return View(Inscripcion);
        }

        // POST: EstudianteController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Delete(Inscripcion Inscripciones)
        {
            if (ModelState.IsValid)
            {
                _context.Remove(Inscripciones);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(Inscripciones);
        }
    }
}
