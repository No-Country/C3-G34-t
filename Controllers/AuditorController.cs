using AuditApp.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
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
        public AuditorController(ApplicationDbContext context)
        {
            _context = context;
        }

        // No pude implementar el route [Route("Panel/Auditor")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
