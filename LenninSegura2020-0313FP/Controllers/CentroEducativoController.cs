using LenninSegura2020_0313FP.Datos;
using LenninSegura2020_0313FP.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace LenninSegura2020_0313FP.Controllers
{
    public class CentroEducativoController : Controller
    {

        //contexto
        private readonly ApplicationDbContext _context;

        public CentroEducativoController(ApplicationDbContext context)
        {
            _context = context;
        }
        // GET: EstudianteController
        // GET: EstudianteController
        public async Task<IActionResult> Index()
        {
            var CentroEducativo = _context.CentrosEducativos;
            return View(await CentroEducativo.ToListAsync());
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

        public async Task<IActionResult> Create(CentroEducativo CentrosEducativos)
        {


            _context.CentrosEducativos.Add(CentrosEducativos);
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
            var CentroEducativo = await _context.Estudiantes.FindAsync(id);

            if (CentroEducativo == null)
            {
                return NotFound();
            }


            return View(CentroEducativo);
        }

        // POST: EstudianteController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit(CentroEducativo CentrosEducativos)
        {
            if (ModelState.IsValid)
            {
                _context.Update(CentrosEducativos);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(CentrosEducativos);
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
            var CentroEducativo = await _context.CentrosEducativos.FindAsync(id);

            if (CentroEducativo == null)
            {
                return NotFound();
            }


            return View(CentroEducativo);
        }

        // POST: EstudianteController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Delete(CentroEducativo CentrosEducativos)
        {
            if (ModelState.IsValid)
            {
                _context.Remove(CentrosEducativos);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(CentrosEducativos);
        }
    }
}
