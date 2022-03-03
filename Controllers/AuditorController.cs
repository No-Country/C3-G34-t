using AuditApp.Data;
using AuditApp.Models;
using Microsoft.AspNetCore.Authorization;
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
    // El data notation de abajo está comentado provisoriamente para poder hacer pruebas en desarrollo sin tener que loguearse
    [Authorize]
    public class AuditorController : Controller
    {
        private readonly ApplicationDbContext _context;
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
            var currentUser = await _userManager.GetUserAsync(HttpContext.User);
            return View();
        }
    }
}
