using LenninSegura2020_0313FP.Datos;
using LenninSegura2020_0313FP.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace LenninSegura2020_0313FP.Controllers
{
    public class ReinscripcionController : Controller
    {

        //contexto
        private readonly ApplicationDbContext _context;

        public ReinscripcionController(ApplicationDbContext context)
        {
            _context = context;
        }
        // GET: EstudianteController
        // GET: EstudianteController
        public async Task<IActionResult> Index()
        {
            var Reinscripcion = _context.Reinscripciones;
            return View(await Reinscripcion.ToListAsync());
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

        public async Task<IActionResult> Create(Reinscripcion Resincripciones)
        {


            _context.Reinscripciones.Add(Resincripciones);
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
            var Reinscripcion = await _context.Reinscripciones.FindAsync(id);

            if (Reinscripcion == null)
            {
                return NotFound();
            }


            return View(Reinscripcion);
        }

        // POST: EstudianteController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit(Reinscripcion Reinscripciones)
        {
            if (ModelState.IsValid)
            {
                _context.Update(Reinscripciones);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(Reinscripciones);
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
            var Reinscripcion = await _context.Reinscripciones.FindAsync(id);

            if (Reinscripcion == null)
            {
                return NotFound();
            }


            return View(Reinscripcion);
        }

        // POST: EstudianteController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Delete(Reinscripcion Reinscripciones)
        {
            if (ModelState.IsValid)
            {
                _context.Remove(Reinscripciones);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(Reinscripciones);
        }
    }
}
