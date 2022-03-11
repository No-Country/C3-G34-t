using AuditApp.Data;
using AuditApp.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
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
        private readonly UserManager<UsuarioBase> _userManager;
        public HyMController(ApplicationDbContext context, UserManager<UsuarioBase> UserManager)
        {
            _context = context;
            _userManager = UserManager;
        }

        [Route("Herramientas/Index/")]
        public async Task<IActionResult> Index()
        {
            IEnumerable<FormHyM> LVHYM;
            try
            {
                var currentUser = await _userManager.GetUserAsync(HttpContext.User);
                LVHYM = await _context.HsyMs.Where(f => f.AuditorGuId.ToString() == currentUser.Id).ToListAsync();
            }
            catch (Exception e)
            {
                return BadRequest(e);
            }

            return View(LVHYM);
        }

        // GET: HyM/Create
        [Route("Herramientas/Nuevo/")]
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

        // POST: HyM/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        //[Bind("IdHyM, Puesto, EPP, LimpiezaYorganizacion, Protecciones, DoblesPulsadores, ParadaDeEmergencia, BarreraOpticaEnclavamientoElectrico, HerramientasManuales, PerdidasAireAguaAceite, Iluminacion, CondicionesInseguras, CarrosEmbalajes, PuertasTablerosElectricos, GuinchesBalanceadores, Entrenamiento, AuditorId, Fecha, Observaciones, ResponsableDesvio, PlantaId")]
        public async Task<IActionResult> Save(FormHyM newHyMFAudit)
        {

            if (ModelState.IsValid)
            { 
                try
                {
                    var id_usuario = newHyMFAudit.AuditorGuId;
                    _context.Add(newHyMFAudit);
                    await _context.SaveChangesAsync();
                    //return RedirectToRoute($"Index?Auditor_Id={newHyMFAudit.AuditorGuId}");
                    //return RedirectToAction("Index", newHyMFAudit.AuditorGuId);
                    //return RedirectToAction("Index", "HyM", newHyMFAudit.AuditorGuId, "Auditor_Id");
                    return RedirectToAction("Index");


                    //string audID = newHyMFAudit.AuditorGuId.ToString();
                    //_context.HsyMs.Add(newHyMFAudit);
                    //await _context.SaveChangesAsync();
                    //return RedirectToAction("Index?Auditor_Id=", audID);
                }
                catch (Exception e)
                {
                    return BadRequest(e);
                }
            }
            return View("Create", newHyMFAudit);
        }

        //{{ServerURL}}/Rol/GetHyMById?id=1
        private FormHyM GetHyMById(int id)
        {
            FormHyM formHyM = new();

            formHyM = _context.HsyMs.FirstOrDefault(f => f.FormID == id);

            return formHyM;
        }


        [Route("Herramientas/Detalles/{id}")]
        // GET: HyM/Details/5
        public IActionResult Details(int id)
        {
            if (id <= 0)
            {
                return NotFound();
            }

            FormHyM formtHyM;
            try
            {
                formtHyM = GetHyMById(id);
                ViewBag.Planta = _context.Plantas.Find(formtHyM.PlantaId).Nombre.ToString();
                if (formtHyM == null)
                {
                    return NotFound();
                }
                else if (ViewBag.Planta == null)
                {
                    ViewBag.Planta = "No Disponible";
                }
                else
                {
                    return View(formtHyM);
                }
            }
            catch (Exception e)
            {
                return BadRequest(e);
            }
            return RedirectToAction("Index");
        }

        // GET: HyM/Edit/5
        //public async Task<IActionResult> Edit(int? id)
        //{
        //    if (id == null)
        //    {
        //        return NotFound();
        //    }

        //    FormHyM editHyM = await _context.HsyMs.FirstOrDefaultAsync(f => f.FormID == id);

        //    if (editHyM == null)
        //    {
        //        return NotFound();
        //    }
        //    return View(editHyM);
        //}

        // POST: HyM/Edit/5
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        ////[Bind("IdHyM, Puesto, EPP, LimpiezaYorganizacion, Protecciones, DoblesPulsadores, ParadaDeEmergencia, BarreraOpticaEnclavamientoElectrico, HerramientasManuales, PerdidasAireAguaAceite, Iluminacion, CondicionesInseguras, CarrosEmbalajes, PuertasTablerosElectricos, GuinchesBalanceadores, Entrenamiento, AuditorId, Fecha, Observaciones, ResponsableDesvio, PlantaId")]
        //public async Task<IActionResult> Edit(int id, FormHyM editHyM)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        try
        //        {
        //            _context.Update(editHyM);
        //            await _context.SaveChangesAsync();
        //            return RedirectToAction(nameof(Index));
        //        }
        //        catch (Exception e)
        //        {
        //            return BadRequest(e);
        //        }
        //    }
        //    return View("Create", editHyM);
        //}

        // GET: HyMController/Delete/5
        //public ActionResult Delete(int id)
        //{
        //    return View();
        //}

        // POST: HyMC/Delete/5
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> Delete(int id)
        //{
        //    FormHyM deleteHyM = new();
        //    try
        //    {
        //        deleteHyM = await _context.HsyMs.FindAsync(id);
        //        _context.Remove(deleteHyM);
        //        await _context.SaveChangesAsync();
        //        return RedirectToAction(nameof(Index));
        //    }
        //    catch (Exception e)
        //    {
        //        return BadRequest(e);
        //    }
            // CHECK
           //eturn View("Delete", deleteHyM);
        //}
    }
}
