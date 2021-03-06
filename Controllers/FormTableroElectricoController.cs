using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using AuditApp.Data;
using AuditApp.Models;
using Microsoft.AspNetCore.Identity;

namespace AuditApp.Controllers
{
    public class FormTableroElectricoController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<UsuarioBase> _userManager;
        public FormTableroElectricoController(ApplicationDbContext context, UserManager<UsuarioBase> UserManager)
        {
            _context = context;
            _userManager = UserManager;
        }

        // GET: FormTableroElectrico
        [Route("Tableros/Index/")]
        public async Task<IActionResult> Index()
        {
            IEnumerable<FormTableroElectrico> LVTE;
            try
            {
                var currentUser = await _userManager.GetUserAsync(HttpContext.User);
                LVTE = await _context.TablerosElectricos.Where(f => f.AuditorGuId.ToString() == currentUser.Id).ToListAsync();

            }
            catch (Exception e)
            {
                return BadRequest(e);
            }

            return View(LVTE);
        }

        // GET: FormTableroElectrico/Details/5
        [Route("Tableros/Detalles/{id}")]
        public async Task<IActionResult> Details(int id)
        {
            if (id <= 0)
            {
                return NotFound();
            }
            FormTableroElectrico formTableroElectrico = new();
            try
            {
                formTableroElectrico = await _context.TablerosElectricos.FirstOrDefaultAsync(m => m.FormID == id);
                ViewBag.Planta = _context.Plantas.Find(formTableroElectrico.PlantaId).Nombre.ToString();
                if (formTableroElectrico == null)
                {
                    return NotFound();
                }
                else if(ViewBag.Planta == null)
                {
                    ViewBag.Planta = "No Disponible";
                }
                else
                {
                    return View(formTableroElectrico);
                }
                
            }
            catch (Exception e)
            {
                return BadRequest(e);
            }
                //catch
                //{
                //    ViewBag.Planta = "No Disponible";
                //}
            return RedirectToAction("Index");
        }


        // GET: FormTableroElectrico/Create
        //public IActionResult Create()
        //{
        //    return View();
        //}
        // GET: HyM/Create
        [Route("Tableros/Nuevo/")]
        public ActionResult Create()
        {
            IEnumerable<Planta> LPlantas;
            try
            {
                LPlantas = _context.Plantas.OrderBy(planta => planta.Nombre);
            }
            catch (Exception e)
            {
                return BadRequest(e);
            }
            ViewData["Plantas"] = LPlantas;

            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Save(FormTableroElectrico newTEAudit)
        {

            if (ModelState.IsValid)
            {
                try
                {
                    var id_usuario = newTEAudit.AuditorGuId;
                    _context.Add(newTEAudit);
                    await _context.SaveChangesAsync();
                   
                    return RedirectToAction("Index");

                }
                catch (Exception e)
                {
                    return BadRequest(e);
                }
            }
            return View("Create", newTEAudit);
        }


        // POST: FormTableroElectrico/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> Create(FormTableroElectrico formTableroElectrico)
        //{
        //    //[Bind("Id,TableroYSector,CarteleriaSeñalizada,CarteleriaBuenEstado,CarteleriaEPP,MPCProcEscritos,MPCCandadosTarjetas,MPCTableroProtegido,EPPCalzadoDielectrico,EPPGuantesDielectrico,EPPLentes,TableroLibre,Cerradura,OrdenLimpieza,Matafuegos,AuditorId,Fecha,Observaciones,ResponsableDesvio,PlantaId")]
        //    if (ModelState.IsValid)
        //    {
        //        _context.Add(formTableroElectrico);
        //        await _context.SaveChangesAsync();
        //        return RedirectToAction(nameof(Index));
        //    }
        //    return View(formTableroElectrico);
        //}

        // GET: FormTableroElectrico/Edit/5
        //public async Task<IActionResult> Edit(int? id)
        //{
        //    if (id == null)
        //    {
        //        return NotFound();
        //    }

        //    var formTableroElectrico = await _context.TablerosElectricos.FindAsync(id);
        //    if (formTableroElectrico == null)
        //    {
        //        return NotFound();
        //    }
        //    return View(formTableroElectrico);
        //}

        // POST: FormTableroElectrico/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> Edit(int id, [Bind("Id,TableroYSector,CarteleriaSeñalizada,CarteleriaBuenEstado,CarteleriaEPP,MPCProcEscritos,MPCCandadosTarjetas,MPCTableroProtegido,EPPCalzadoDielectrico,EPPGuantesDielectrico,EPPLentes,TableroLibre,Cerradura,OrdenLimpieza,Matafuegos,AuditorId,Fecha,Observaciones,ResponsableDesvio,PlantaId")] FormTableroElectrico formTableroElectrico)
        //{
        //    if (id != formTableroElectrico.FormID)
        //    {
        //        return NotFound();
        //    }

        //    if (ModelState.IsValid)
        //    {
        //        try
        //        {
        //            _context.Update(formTableroElectrico);
        //            await _context.SaveChangesAsync();
        //        }
        //        catch (DbUpdateConcurrencyException)
        //        {
        //            if (!FormTableroElectricoExists(formTableroElectrico.FormID))
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
        //    return View(formTableroElectrico);
        //}

        // GET: FormTableroElectrico/Delete/5
        //public async Task<IActionResult> Delete(int? id)
        //{
        //    if (id == null)
        //    {
        //        return NotFound();
        //    }

        //    var formTableroElectrico = await _context.TablerosElectricos
        //        .FirstOrDefaultAsync(m => m.FormID == id);
        //    if (formTableroElectrico == null)
        //    {
        //        return NotFound();
        //    }

        //    return View(formTableroElectrico);
        //}

        // POST: FormTableroElectrico/Delete/5
        //[HttpPost, ActionName("Delete")]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> DeleteConfirmed(int id)
        //{
        //    var formTableroElectrico = await _context.TablerosElectricos.FindAsync(id);
        //    _context.TablerosElectricos.Remove(formTableroElectrico);
        //    await _context.SaveChangesAsync();
        //    return RedirectToAction(nameof(Index));
        //}

        private bool FormTableroElectricoExists(int id)
        {
            return _context.TablerosElectricos.Any(e => e.FormID == id);
        }
    }
}
