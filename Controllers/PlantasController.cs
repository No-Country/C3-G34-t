using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using AuditApp.Data;
using AuditApp.Models;

namespace AuditApp.Controllers
{
    public class PlantasController : Controller
    {
        private readonly ApplicationDbContext _context;

        public PlantasController(ApplicationDbContext context)
        {
            _context = context;
        }


        // GET: Plantas
        [Route("Plantas/Index/")]
        public async Task<IActionResult> Index()
        {
            return View(await _context.Plantas.OrderBy(planta => planta.Nombre).ToListAsync());
        }


        // GET: Plantas/Details/5
        [Route("Plantas/Detalles/{id}")]
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var planta = await _context.Plantas
                .FirstOrDefaultAsync(m => m.Id == id);
            if (planta == null)
            {
                return NotFound();
            }

            return View(planta);
        }


        // GET: Plantas/Create
        [Route("Plantas/Nueva/")]
        public IActionResult Create()
        {
            return View();
        }

        // POST: Plantas/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Save([Bind("Id,Nombre")] Planta planta)
        {
            if (ModelState.IsValid)
            {
                _context.Add(planta);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(planta);
        }

        // GET: Plantas/Edit/5
        //public async Task<IActionResult> Edit(int? id)
        //{
        //    if (id == null)
        //    {
        //        return NotFound();
        //    }

        //    var planta = await _context.Plantas.FindAsync(id);
        //    if (planta == null)
        //    {
        //        return NotFound();
        //    }
        //    return View(planta);
        //}

        // POST: Plantas/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> Edit(int id, [Bind("Id,Nombre")] Planta planta)
        //{
        //    if (id != planta.Id)
        //    {
        //        return NotFound();
        //    }

        //    if (ModelState.IsValid)
        //    {
        //        try
        //        {
        //            _context.Update(planta);
        //            await _context.SaveChangesAsync();
        //        }
        //        catch (DbUpdateConcurrencyException)
        //        {
        //            if (!PlantaExists(planta.Id))
        //            {
        //                return NotFound();
        //            }
        //            else
        //            {
        //                throw;
        //            }
        //        }
        //        return RedirectToAction(nameof(Index));
        //    }
        //    return View(planta);
        //}

        // GET: Plantas/Delete/5
        //public async Task<IActionResult> Delete(int? id)
        //{
        //    if (id == null)
        //    {
        //        return NotFound();
        //    }

        //    var planta = await _context.Plantas
        //        .FirstOrDefaultAsync(m => m.Id == id);
        //    if (planta == null)
        //    {
        //        return NotFound();
        //    }

        //    return View(planta);
        //}

        // POST: Plantas/Delete/5
        //[HttpPost, ActionName("Delete")]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> DeleteConfirmed(int id)
        //{
        //    var planta = await _context.Plantas.FindAsync(id);
        //    _context.Plantas.Remove(planta);
        //    await _context.SaveChangesAsync();
        //    return RedirectToAction(nameof(Index));
        //}

        private bool PlantaExists(int id)
        {
            return _context.Plantas.Any(e => e.Id == id);
        }
    }
}
