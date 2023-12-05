using LenninSegura2020_0313FP.Datos;
using LenninSegura2020_0313FP.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace LenninSegura2020_0313FP.Controllers
{
    public class AnoEscolarController : Controller
    {

        //contexto
        private readonly ApplicationDbContext _context;

        public AnoEscolarController(ApplicationDbContext context)
        {
            _context = context;
        }
        // GET: EstudianteController
        // GET: EstudianteController
        public async Task<IActionResult> Index()
        {
            var AnoEscolar = _context.AnoEscolars;
            return View(await AnoEscolar.ToListAsync());
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

        public async Task<IActionResult> Create(AnoEscolar AnoEscolars)
        {


            _context.AnoEscolars.Add(AnoEscolars);
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
            var AnoEscolar = await _context.AnoEscolars.FindAsync(id);

            if (AnoEscolar == null)
            {
                return NotFound();
            }


            return View(AnoEscolar);
        }

        // POST: EstudianteController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit(AnoEscolar AnoEscolars)
        {
            if (ModelState.IsValid)
            {
                _context.Update(AnoEscolars);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(AnoEscolars);
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
            var AnoEscolars = await _context.Estudiantes.FindAsync(id);

            if (AnoEscolars == null)
            {
                return NotFound();
            }


            return View(AnoEscolars);
        }

        // POST: EstudianteController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Delete(AnoEscolar AnoEscolars)
        {
            if (ModelState.IsValid)
            {
                _context.Remove(AnoEscolars);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(AnoEscolars);
        }
    }
}
