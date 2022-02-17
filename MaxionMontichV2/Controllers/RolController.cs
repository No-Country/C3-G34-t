using MaxionMontichV2.Data;
using MaxionMontichV2.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MaxionMontichV2.Controllers
{
    public class RolController : Controller
    {
        private readonly ApplicationDbContext _context;
        public RolController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        //{{ServerURL}}/Rol/GetRol
        public async Task<IActionResult> GetRol()
        {
            IEnumerable<Rol> LisRols = null;
            try
            {
                LisRols = _context.Rol;
            }
            catch (Exception e)
            {
                return BadRequest();
            }
            return Ok(LisRols);
        }

        [HttpGet]
        //{{ServerURL}}/Rol/GetRolById?id=1
        public async Task<IActionResult> GetRolById(int id)
        {
            Rol rol = new Rol();
            try
            {
                if (id == null || id == 0)
                {
                    return NotFound();
                }

                rol = _context.Rol.Find(id);

                if (rol == null)
                {
                    return NotFound();
                }
            }
            catch (Exception e)
            {
                return BadRequest();
            }
            return Ok(rol);
        }

        [HttpPost]
        //{{ServerURL}}/ Rol / CreateRol /
        public async Task<IActionResult> CreateRol([FromBody] Rol rol)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    _context.Rol.Add(rol);
                    await _context.SaveChangesAsync();
                    TempData["mensaje"] = "El rol se ha creado exitosamente";
                }
                catch (Exception e)
                {
                    return BadRequest();
                }
            }
            return Ok(rol);
        }

        [HttpGet]
        //{{ServerURL}}/Rol/SearchRol?id=5
        public async Task<IActionResult> SearchRol(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            var rol = _context.Rol.Find(id);

            if (rol == null)
            {
                return NotFound();
            }

            return Ok(rol);
        }

        [HttpPost]
        //{{ServerURL}}/Rol/EditRol?id=5
        public async Task<IActionResult> EditRol([FromBody] Rol rol)
        {
            if (ModelState.IsValid)
            {
                _context.Rol.Update(rol);
                _context.SaveChanges();
                
                TempData["mensaje"] = "El rol se ha Actualizado exitosamente";

                return RedirectToAction("Index");
            }

            return Ok(rol);
        }

        [HttpPost]
        //{{ServerURL}}/Rol/DeleteRol?id=10
        public IActionResult DeleteRol(int? id)
        {
            var rol = _context.Rol.Find(id);

            if (rol == null)
            {
                return NotFound();
            }

            _context.Rol.Remove(rol);
            _context.SaveChanges();

            TempData["mensaje"] = "El rol se ha Eliminado exitosamente";

            return Ok();
        }

    }
}
