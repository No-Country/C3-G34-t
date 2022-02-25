using AuditApp.Data;
using AuditApp.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AuditApp.Controllers
{
    public class FAutoElevadoresController : Controller
    {
        private readonly ApplicationDbContext _context;

        public FAutoElevadoresController(ApplicationDbContext context)
        {
            _context = context;
        }


        public IActionResult Index(Guid Auditor_Id)
        {
            IEnumerable<FormAutoElevadores> LVFAE = null;
            string u = "";
            try
            {
                LVFAE = _context.AutoElevadores.Where(x => x.AuditorGuId.Equals(Auditor_Id)).ToList();
                
            }
            catch (Exception e)
            {
                return BadRequest();
            }

            return View(LVFAE);
        }

        [HttpGet]
        //HTTP GET
        public IActionResult Create()
        {
            IEnumerable <Planta> LPlantas = null;
            try
            {
                LPlantas = _context.Plantas;
            }
            catch (Exception e)
            {
                return BadRequest();
            }
            ViewData["Plantas"]=LPlantas;
            ViewBag.Auditores = "";

            return View();
        }

        [HttpGet]
        //{{ServerURL}}/Rol/GetFAE
        public async Task<IActionResult> GetFAE()
        {
            IEnumerable<FormAutoElevadores> LisFAE = null;
            try
            {
                LisFAE = _context.AutoElevadores;
            }
            catch (Exception e)
            {
                return BadRequest();
            }
            return View(LisFAE);
        }
        
        [HttpGet]
        //{{ServerURL}}/Rol/DetailsId?id=1
        public async Task<IActionResult> Details(int id)
        {
            FormAutoElevadores FAE = new FormAutoElevadores();
            ViewBag.Planta = "";
            try
            {
                if (id == null || id == 0)
                {
                    return NotFound();
                }
                FAE = _context.AutoElevadores.Find(id);
                try
                {
                    ViewBag.Planta = _context.Plantas.Find(FAE.PlantaId).Nombre.ToString();
                }
                catch {
                    ViewBag.Planta = "No Disponible";
                       }

                if (FAE == null)
                {
                    return NotFound();
                }
            }
            catch (Exception e)
            {
                return BadRequest();
            }
            return View(FAE);
        }

        [HttpPost]
        //{{ServerURL}}/ Rol / CreateFAE /        [FromBody]
        public async Task<IActionResult> CreateFAE(FormAutoElevadores fae)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    _context.AutoElevadores.Add(fae);
                    await _context.SaveChangesAsync();
                    TempData["mensaje"] = "El Formulario se ha Guardado exitosamente";
                }
                catch (Exception e)
                {
                    return BadRequest();
                }
            }
            return Redirect("Index");
        }




        //Metodo agregado para concultar plantas desde otro Lugar diferente a la propia vista
        [HttpGet]
        //{{ServerURL}}/Rol/GetF
        public async Task<IActionResult> GetPlantas()
        {
            IEnumerable<Planta> LPlantas = null;
            try
            {
                LPlantas = _context.Plantas;
            }
            catch (Exception e)
            {
                return BadRequest();
            }
            return Ok(LPlantas);
        }


    }
}
