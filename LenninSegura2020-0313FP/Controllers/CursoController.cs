using LenninSegura2020_0313FP.Datos;
using LenninSegura2020_0313FP.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace LenninSegura2020_0313FP.Controllers
{
    public class CursoController : Controller
    {

        //contexto
        private readonly ApplicationDbContext _context;

        public CursoController(ApplicationDbContext context)
        {
            _context = context;
        }
        // GET: EstudianteController
        // GET: EstudianteController
        public async Task<IActionResult> Index()
        {
            var Curso = _context.Cursos;
            return View(await Curso.ToListAsync());
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

        public async Task<IActionResult> Create(Curso Cursos)
        {


            _context.Cursos.Add(Cursos);
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
            var Curso = await _context.Cursos.FindAsync(id);

            if (Curso == null)
            {
                return NotFound();
            }


            return View(Curso);
        }

        // POST: EstudianteController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit(Curso Cursos)
        {
            if (ModelState.IsValid)
            {
                _context.Update(Cursos);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(Cursos);
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
            var Curso = await _context.Cursos.FindAsync(id);

            if (Curso == null)
            {
                return NotFound();
            }


            return View(Curso);
        }

        // POST: EstudianteController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Delete(Curso Cursos)
        {
            if (ModelState.IsValid)
            {
                _context.Remove(Cursos);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(Cursos);
        }
    }
}
