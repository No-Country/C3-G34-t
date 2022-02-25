using AuditApp.Data;
using AuditApp.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AuditApp.Controllers
{
    public class HyMController : Controller
    {
        private readonly ApplicationDbContext _context;
        public HyMController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index(Guid Auditor_Id)
        {
            IEnumerable<FormHyM> LVHYV = null;
            string u = "";
            try
            {
                LVHYV = _context.HsyMs.Where(x => x.AuditorGuId.Equals(Auditor_Id)).ToList();

            }
            catch (Exception e)
            {
                return BadRequest();
            }

            return View(LVHYV);
        }

        // GET: HyM
        //public async Task<IActionResult> Index()
        //{
        //    //return View("../Auditor/Index");
        //    return View(await _context.HsyMs.ToListAsync());
        //}

        // GET: HyM/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var formtHyM = await _context.HsyMs.FirstOrDefaultAsync(hym => hym.IdHyM == id);

            if (formtHyM == null)
            {
                return NotFound();

            }

            return View(formtHyM);

            //IEnumerable<FormHyM> ListHyM;
            //try
            //{
            //    ListHyM = await _context.HsyMs.ToListAsync();
            //}
            //catch (Exception e)
            //{
            //    return BadRequest(e);
            //}
            //return Ok(ListHyM);
        }

        [HttpGet]
        [Route("HyM/Details")]
        //{{ServerURL}}/Rol/GetHyMById?id=1
        public async Task<IActionResult> GetHyMById(int id)
        {
            FormHyM formHyM = new();
            try
            {
                if (id <= 0)
                {
                    return NotFound();
                }

                formHyM = await _context.HsyMs.FirstOrDefaultAsync(f => f.FormID == id);

                if (formHyM == null)
                {
                    return NotFound();
                }
            }
            catch (Exception e)
            {
                return BadRequest(e);
            }
            return View("Details", formHyM);
        }

        // GET: HyM/Create
        public ActionResult Create()
        {                                
            IEnumerable<Planta> LPlantas;
            try
            {
                LPlantas = _context.Plantas;
            }
            catch (Exception e)
            {
                return BadRequest(e);
            }
            ViewData["Plantas"] = LPlantas;

            return View();
        }

        // POST: HyM/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdHyM, Puesto, EPP, LimpiezaYorganizacion, Protecciones, DoblesPulsadores, ParadaDeEmergencia, BarreraOpticaEnclavamientoElectrico, HerramientasManuales, PerdidasAireAguaAceite, Iluminacion, CondicionesInseguras, CarrosEmbalajes, PuertasTablerosElectricos, GuinchesBalanceadores, Entrenamiento, AuditorId, Fecha, Observaciones, ResponsableDesvio, PlantaId")] FormHyM newHyMFAudit)
        {

            if (ModelState.IsValid)
            { 
                try
                {
                    _context.Add(newHyMFAudit);
                    await _context.SaveChangesAsync();
                    return RedirectToAction(nameof(Index));
                }
                catch (Exception e)
                {
                    return BadRequest(e);
                }
            }
            return View("Create", newHyMFAudit);
        }

        // GET: HyM/Edit/5

        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            FormHyM editHyM = await _context.HsyMs.FirstOrDefaultAsync(f => f.FormID == id);

            if (editHyM == null)
            {
                return NotFound();
            }
            return View(editHyM);
        }

        // POST: HyM/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IdHyM, Puesto, EPP, LimpiezaYorganizacion, Protecciones, DoblesPulsadores, ParadaDeEmergencia, BarreraOpticaEnclavamientoElectrico, HerramientasManuales, PerdidasAireAguaAceite, Iluminacion, CondicionesInseguras, CarrosEmbalajes, PuertasTablerosElectricos, GuinchesBalanceadores, Entrenamiento, AuditorId, Fecha, Observaciones, ResponsableDesvio, PlantaId")] FormHyM editHyM)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(editHyM);
                    await _context.SaveChangesAsync();
                    return RedirectToAction(nameof(Index));
                }
                catch (Exception e)
                {
                    return BadRequest(e);
                }
            }
            return View("Create", editHyM);
        }

        // GET: HyMController/Delete/5
        //public ActionResult Delete(int id)
        //{
        //    return View();
        //}

        // POST: HyMC/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(int id)
        {
            FormHyM deleteHyM = new();
            try
            {
                deleteHyM = await _context.HsyMs.FindAsync(id);
                _context.Remove(deleteHyM);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            catch (Exception e)
            {
                return BadRequest(e);
            }
            // CHECK
           //eturn View("Delete", deleteHyM);
        }
    }
}
