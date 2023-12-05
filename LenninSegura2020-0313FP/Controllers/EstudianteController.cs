using LenninSegura2020_0313FP.Datos;
using LenninSegura2020_0313FP.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace LenninSegura2020_0313FP.Controllers
{
    public class EstudianteController : Controller
    {

        //contexto
        private readonly ApplicationDbContext _context;

        public EstudianteController(ApplicationDbContext context)
        {
            _context = context;
        }
        // GET: EstudianteController
        // GET: EstudianteController
        public async Task<IActionResult> Index()
        {
            var Estudiantes = _context.Estudiantes;
            return View(await Estudiantes.ToListAsync());
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

        public async Task<IActionResult> Create(Estudiante estudiante)
        {


            _context.Estudiantes.Add(estudiante);
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
            var estudiante = await _context.Estudiantes.FindAsync(id);

            if (estudiante == null)
            {
                return NotFound();
            }


            return View(estudiante);
        }

        // POST: EstudianteController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit(Estudiante estudiante)
        {
            if (ModelState.IsValid)
            {
                _context.Update(estudiante);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(estudiante);
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
            var estudiante = await _context.Estudiantes.FindAsync(id);

            if (estudiante == null)
            {
                return NotFound();
            }


            return View(estudiante);
        }

        // POST: EstudianteController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Delete(Estudiante estudiante)
        {
            if (ModelState.IsValid)
            {
                _context.Remove(estudiante);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(estudiante);
        }
    }
}
