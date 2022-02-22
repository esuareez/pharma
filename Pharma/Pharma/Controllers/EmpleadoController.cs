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
        public ActionResult Dashboard()
        {
            return View();
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
                    return RedirectToAction("Employee");
                }

            }
            return View("Dashboard");
        }
    }
}
