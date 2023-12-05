using LenninSegura2020_0313FP.Datos;
using LenninSegura2020_0313FP.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace LenninSegura2020_0313FP.Controllers
{
    public class MaestroController : Controller
    {
        private readonly ApplicationDbContext _context;

        public MaestroController(ApplicationDbContext context)
        {
            _context = context;
        }
        // GET: MaestroController
        public async Task<IActionResult> Index()
        {
            var Maestro = _context.Maestros;
            return View(await Maestro.ToListAsync());
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

        public async Task<IActionResult> Create(Maestro maestro)
        {


            _context.Maestros.Add(maestro);
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
            var maestro = await _context.Maestros.FindAsync(id);

            if (maestro == null)
            {
                return NotFound();
            }


            return View(maestro);
        }

        // POST: EstudianteController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit(Maestro maestro)
        {
            if (ModelState.IsValid)
            {
                _context.Update(maestro);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(maestro);
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
            var maestro = await _context.Maestros.FindAsync(id);

            if (maestro == null)
            {
                return NotFound();
            }


            return View(maestro);
        }

        // POST: EstudianteController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Delete(Maestro maestro)
        {
            if (ModelState.IsValid)
            {
                _context.Remove(maestro);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(maestro);
        }
    }
}
