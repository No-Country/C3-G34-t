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
    public class FAutoElevadoresController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<UsuarioBase> _userManager;
        public FAutoElevadoresController(ApplicationDbContext context, UserManager<UsuarioBase> UserManager)
        {
            _context = context;
            _userManager = UserManager;
        }

        [Route("Autoelevadores/Index/")]
        public async Task<IActionResult> Index()
        {
            IEnumerable<FormAutoElevadores> LVFAE;
            try
            {
                var currentUser = await _userManager.GetUserAsync(HttpContext.User);
                LVFAE = await _context.AutoElevadores.Where(f => f.AuditorGuId.ToString() == currentUser.Id).ToListAsync();
            }
            catch (Exception e)
            {
                return BadRequest(e);
            }
            return View(LVFAE);
        }

        [HttpGet]
        //HTTP GET
        [Route("Autoelevadores/Nuevo/")]
        public IActionResult Create()
        {
            IEnumerable <Planta> LPlantas;
            try
            {
                LPlantas = _context.Plantas.OrderBy(planta => planta.Nombre);
            }
            catch (Exception e)
            {
                return BadRequest(e);
            }
            ViewData["Plantas"] = LPlantas;
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
        [Route("Autoelevadores/Detalles/{id}")]
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
                catch
                {
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
                    return RedirectToAction("Index");
                }
                catch (Exception e)
                {
                    return BadRequest(e);
                }
            }
            return View("Create", fae);
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
