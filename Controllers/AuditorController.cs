using AuditApp.Data;
<<<<<<< HEAD
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
=======
using AuditApp.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
>>>>>>> Developers
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AuditApp.Controllers
{
    // El data notation de abajo está comentado provisoriamente para poder hacer pruebas en desarrollo sin tener que loguearse
    [Authorize]
    public class AuditorController : Controller
    {
        private readonly ApplicationDbContext _context;
<<<<<<< HEAD
        public AuditorController(ApplicationDbContext context)
        {
            _context = context;
        }

        // No pude implementar el route [Route("Panel/Auditor")]
        public IActionResult Index()
        {
            return View();
        }
=======
        private readonly UserManager<UsuarioBase> _userManager;
        public AuditorController(ApplicationDbContext context, UserManager<UsuarioBase> UserManager)
        {
            _context = context;
            _userManager = UserManager;
        }

        [Route("~/")]
        [Route("Auditor")]
        [Route("Auditor/Index/")]
        // No pude implementar el route [Route("Panel/Auditor")]
        public async Task<IActionResult> Index()
        {
            Dictionary<string, int> contadores = new Dictionary<string, int>()
            {{"HYM",0 },{"Tableros",0}, {"AutoElevadores",0}};
            List<charts> PlantaCont = new List<charts>();
            //Dictionary<string,int> PlantaCont = new Dictionary<string,int>();
            
            try
            {
                var currentUser = await _userManager.GetUserAsync(HttpContext.User);
                ViewBag.AElevadores = await _context.AutoElevadores.Where(x => x.AuditorGuId.ToString() == currentUser.Id).CountAsync();
                ViewBag.HYM = await _context.HsyMs.Where(x => x.AuditorGuId.ToString() == currentUser.Id).CountAsync();
                ViewBag.Tableros = await _context.TablerosElectricos.Where(x => x.AuditorGuId.ToString() == currentUser.Id).CountAsync();

                IEnumerable<Planta> LPlantas = null;
                LPlantas = _context.Plantas;



                foreach (var item in LPlantas)
                {
                    var cant = 0;
                    cant = await _context.AutoElevadores.Where(x => x.AuditorGuId.ToString() == currentUser.Id && x.PlantaId == item.Id).CountAsync();
                    cant += await _context.HsyMs.Where(x => x.AuditorGuId.ToString() == currentUser.Id && x.PlantaId == item.Id).CountAsync();
                    cant += await _context.TablerosElectricos.Where(x => x.AuditorGuId.ToString() == currentUser.Id && x.PlantaId == item.Id).CountAsync();

                    PlantaCont.Add(new charts { MyLabel = item.Nombre.ToString(), MyData = cant });
                    //PlantaCont[item.Nombre.ToString()] = cant;
                    //ViewBag.labels.Add(item.Nombre);
                    //ViewBag.datas.Add(cant);
                }
            }
            catch (Exception e)
            {
                return View();
            }

            return View(PlantaCont);
        }

        public class charts
        {
            public string MyLabel { get; set; }
            public int MyData { get; set; }
        }

>>>>>>> Developers
    }
}
