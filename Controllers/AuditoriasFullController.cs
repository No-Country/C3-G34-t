using AuditApp.Data;
using AuditApp.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;


namespace AuditApp.Controllers
{
    public class AuditoriasFullController : Controller
    {

        private readonly ApplicationDbContext _context;

        public AuditoriasFullController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Index(int Auth_id)
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
                LVFAE = _context.AutoElevadores.Where(x => x.AuditorId.Equals(Auth_id)).ToList();
                LVTE = _context.TablerosElectricos.Where(x => x.AuditorId.Equals(Auth_id)).ToList();
                LVHyM = _context.HsyMs.Where(x => x.AuditorId.Equals(Auth_id)).ToList();
                LPlantas = _context.Plantas.ToList();

                foreach (var item in LVFAE)
                {
                    AuditoriasView Auth = new AuditoriasView();
                    Auth.PlantaName = LPlantas.Where(x => x.Id.Equals(item.PlantaId)).FirstOrDefault().Nombre.ToString();
                    Auth.Fecha = item.Fecha.ToString();
                    Auth.TipoFormulario = "AutoElevadores";
                    Auth.controlador = "FAutoElevadores";
                    Auth.IdFormulario = item.Id;
                    All.Add(Auth);
                }

                foreach (var item in LVTE)
                {
                    AuditoriasView Auth = new AuditoriasView();
                    Auth.PlantaName = LPlantas.Where(x => x.Id == item.PlantaId).FirstOrDefault().Nombre;
                    Auth.Fecha = item.Fecha.ToString();
                    Auth.TipoFormulario = "Tableros Electricos";
                    Auth.controlador = "FormTableroElectrico";
                    Auth.IdFormulario = item.Id;
                    All.Add(Auth);
                }

                foreach (var item in LVHyM)
                {
                    AuditoriasView Auth = new AuditoriasView();
                    Auth.PlantaName = LPlantas.Where(x => x.Id == item.PlantaId).FirstOrDefault().Nombre;
                    Auth.Fecha = item.Fecha.ToString();
                    Auth.TipoFormulario = "Herramientas y Maquinas";
                    Auth.controlador = "HyM";
                    Auth.IdFormulario = item.Id;
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

            return View(All);
        }





    }
}
