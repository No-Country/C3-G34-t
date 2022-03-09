using AuditApp.Data;
using AuditApp.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;


namespace AuditApp.Controllers
{
    public class AuditoriasFullController : Controller
    {

        private readonly ApplicationDbContext _context;
        private readonly UserManager<UsuarioBase> _userManager;
        public AuditoriasFullController(ApplicationDbContext context, UserManager<UsuarioBase> UserManager)
        {
            _context = context;
            _userManager = UserManager;
        }
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            //ViewData["AE"] = "";
            //ViewData["TE"] = "";
            //ViewData["HYM"] = "";

            List<FormAutoElevadores> LVFAE = null;
            IEnumerable<FormTableroElectrico> LVTE = null;
            IEnumerable<FormHyM> LVHyM = null;
            List<Planta> LPlantas = new List<Planta>();
            List<AuditoriasView> All = new();

            try
            {                
                var currentUser = await _userManager.GetUserAsync(HttpContext.User);
                LVFAE = _context.AutoElevadores.Where(x => x.AuditorGuId.ToString() == currentUser.Id).ToList();
                LVTE = _context.TablerosElectricos.Where(x => x.AuditorGuId.ToString() == currentUser.Id).ToList();
                LVHyM = _context.HsyMs.Where(x => x.AuditorGuId.ToString() == currentUser.Id).ToList();
                LPlantas = _context.Plantas.ToList();

                foreach (var item in LVFAE)
                {
                    AuditoriasView Auth = new AuditoriasView();
                    Auth.PlantaName = LPlantas.Where(x => x.Id.Equals(item.PlantaId)).FirstOrDefault().Nombre.ToString();
                    Auth.Fecha = item.Fecha.ToString();
                    Auth.TipoFormulario = "AutoElevadores";
                    Auth.controlador = "FAutoElevadores";
                    Auth.IdFormulario = item.FormID;
                    All.Add(Auth);
                }

                foreach (var item in LVTE)
                {
                    AuditoriasView Auth = new AuditoriasView();
                    Auth.PlantaName = LPlantas.Where(x => x.Id == item.PlantaId).FirstOrDefault().Nombre;
                    Auth.Fecha = item.Fecha.ToString();
                    Auth.TipoFormulario = "Tableros Electricos";
                    Auth.controlador = "FormTableroElectrico";
                    Auth.IdFormulario = item.FormID;
                    All.Add(Auth);
                }

                foreach (var item in LVHyM)
                {
                    AuditoriasView Auth = new AuditoriasView();
                    Auth.PlantaName = LPlantas.Where(x => x.Id == item.PlantaId).FirstOrDefault().Nombre;
                    Auth.Fecha = item.Fecha.ToString();
                    Auth.TipoFormulario = "Herramientas y Maquinas";
                    Auth.controlador = "HyM";
                    Auth.IdFormulario = item.FormID;
                    All.Add(Auth);
                }


                //    ViewData["AE"] = LVFAE;
                //    ViewData["TE"] = LVTE;
                //    ViewData["HYM"] = LVHyM;
                //    ViewData["Plantas"] = LPlantas;
            }
            catch (Exception e)
            {
                return BadRequest();
            }

            return View(All.OrderByDescending(f => f.Fecha));
        }





    }
}
