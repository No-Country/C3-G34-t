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
    public class FormTableroElectricoController : Controller
    {
        private readonly ApplicationDbContext _context;

        public FormTableroElectricoController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: FormTableroElectrico
        public async Task<IActionResult> Index()
        {
            return View(await _context.TablerosElectricos.ToListAsync());
        }

        // GET: FormTableroElectrico/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var formTableroElectrico = await _context.TablerosElectricos
                .FirstOrDefaultAsync(m => m.Id == id);
            if (formTableroElectrico == null)
            {
                return NotFound();
            }

            return View(formTableroElectrico);
        }

        // GET: FormTableroElectrico/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: FormTableroElectrico/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,TableroYSector,CarteleriaSeñalizada,CarteleriaBuenEstado,CarteleriaEPP,MPCProcEscritos,MPCCandadosTarjetas,MPCTableroProtegido,EPPCalzadoDielectrico,EPPGuantesDielectrico,EPPLentes,TableroLibre,Cerradura,OrdenLimpieza,Matafuegos,AuditorId,Fecha,Observaciones,ResponsableDesvio,PlantaId")] FormTableroElectrico formTableroElectrico)
        {
            if (ModelState.IsValid)
            {
                _context.Add(formTableroElectrico);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(formTableroElectrico);
        }

        // GET: FormTableroElectrico/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var formTableroElectrico = await _context.TablerosElectricos.FindAsync(id);
            if (formTableroElectrico == null)
            {
                return NotFound();
            }
            return View(formTableroElectrico);
        }

        // POST: FormTableroElectrico/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,TableroYSector,CarteleriaSeñalizada,CarteleriaBuenEstado,CarteleriaEPP,MPCProcEscritos,MPCCandadosTarjetas,MPCTableroProtegido,EPPCalzadoDielectrico,EPPGuantesDielectrico,EPPLentes,TableroLibre,Cerradura,OrdenLimpieza,Matafuegos,AuditorId,Fecha,Observaciones,ResponsableDesvio,PlantaId")] FormTableroElectrico formTableroElectrico)
        {
            if (id != formTableroElectrico.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(formTableroElectrico);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!FormTableroElectricoExists(formTableroElectrico.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(formTableroElectrico);
        }

        // GET: FormTableroElectrico/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var formTableroElectrico = await _context.TablerosElectricos
                .FirstOrDefaultAsync(m => m.Id == id);
            if (formTableroElectrico == null)
            {
                return NotFound();
            }

            return View(formTableroElectrico);
        }

        // POST: FormTableroElectrico/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var formTableroElectrico = await _context.TablerosElectricos.FindAsync(id);
            _context.TablerosElectricos.Remove(formTableroElectrico);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool FormTableroElectricoExists(int id)
        {
            return _context.TablerosElectricos.Any(e => e.Id == id);
        }
    }
}
