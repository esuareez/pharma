using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Pharma.Models;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;

namespace Pharma.Controllers
{
    public class EmpleadoController : Controller
    {
        private readonly FarmaciaContext _context;
        public EmpleadoController(FarmaciaContext context)
        {
            _context = context;
        }
        public ActionResult Dashboard(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            // Obtener cliente

            var empleado = _context.Empleados.Find(id);

            if (empleado == null)
            {
                return NotFound();
            }

            return View(empleado);
        }

        public ActionResult Create()
        {
            return View();
        }

        public ActionResult Employee()
        {
            IEnumerable<Empleado> listEmpleado = _context.Empleados;
            return View(listEmpleado);
        }

        [HttpPost]
        [ValidateAntiForgeryToken] // que un bot no pueda enviar muchas request
        public IActionResult Create(Empleado empleado)
        {
            if (ModelState.IsValid)
            {
                var _empleado = _context.Empleados.Where(s => s.Correo == empleado.Correo && s.Cedula == empleado.Cedula);
                if (_empleado.Any())
                {
                    //sweetalert
                }
                else
                {
                    _context.Empleados.Add(empleado);
                    _context.SaveChanges();
                    //CookieOptions cookieOptions = new CookieOptions();
                    //cookieOptions.Expires = new DateTimeOffset(DateTime.Now.AddDays(7));
                    //HttpContext.Response.Cookies.Append("userId", cliente.Id.ToString(), cookieOptions);
                    return RedirectToAction("Employee");
                }

            }
            return View("Dashboard");
        }
    }
}
