using AuditApp.Data;
using AuditApp.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
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
        //public IActionResult Index()
        //{
        //    return View();
        //}

        [HttpGet]
        //{{ServerURL}}/Rol/GetRol
        public async Task<IActionResult> GetAE()
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
            return Ok(LisFAE);
        }


        [HttpGet]
        //{{ServerURL}}/Rol/GetRolById?id=1
        public async Task<IActionResult> GetFAEById(int id)
        {
            FormAutoElevadores FAE = new FormAutoElevadores();
            try
            {
                if (id == null || id == 0)
                {
                    return NotFound();
                }

                FAE = _context.AutoElevadores.Find(id);

                if (FAE == null)
                {
                    return NotFound();
                }
            }
            catch (Exception e)
            {
                return BadRequest();
            }
            return Ok(FAE);
        }

        [HttpPost]
        //{{ServerURL}}/ Rol / CreateRol /
        public async Task<IActionResult> CreateFAE([FromBody] FormAutoElevadores fae)
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
            return Ok(fae);
        }




    }
}
