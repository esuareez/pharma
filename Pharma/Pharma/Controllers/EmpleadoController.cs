using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Pharma.Extensions;
using Pharma.Models;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;

namespace Pharma.Controllers
{
    public class EmpleadoController : BaseController
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
                var _empleado = _context.Empleados.Where(s => s.Correo == empleado.Correo || s.Cedula == empleado.Cedula);
                if (_empleado.Any())
                {
                    BasicNotification("Empleado existente", NotificationType.Error, "Ya existe un empleado con este correo y cedula.");
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

        public IActionResult EditProfile(int? id)
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

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult EditProfile(Empleado empleado)
        {
            if (ModelState.IsValid)
            {
                CookieOptions cookieOptions = new CookieOptions();
                cookieOptions.Expires = new DateTimeOffset(DateTime.Now.AddDays(1));
                HttpContext.Response.Cookies.Append("emplId", empleado.IdEmpleado.ToString(), cookieOptions);
                HttpContext.Response.Cookies.Append("name", empleado.Nombre, cookieOptions);
                HttpContext.Response.Cookies.Append("lastname", empleado.Apellido, cookieOptions);
                HttpContext.Response.Cookies.Append("rol", empleado.Puesto, cookieOptions);
                _context.Empleados.Update(empleado);
                _context.SaveChanges();
                BasicNotification("Actualizar empleado", NotificationType.Success, "El empleado se ha actualizado correctamente.");
                if (empleado.Puesto == "Farmacéutico")
                    return RedirectToAction("Dashboard");
                return RedirectToAction("Employee");
            }
            return View();
        }

        public IActionResult Delete(int? id)
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
        //HTTP Get Delete
        
        public void RemoveEmp(int? id)
        {
            // Obtener cliente por id
            var empleado = _context.Empleados.Find(id);
            _context.Empleados.Remove(empleado);
            _context.SaveChanges();
            BasicNotification("Eliminacion empleado", NotificationType.Success, "El empleado se ha eliminado correctamente.");
            if (empleado.IdEmpleado == int.Parse(Request.Cookies["emplId"]))
			{
                CookieOptions cookieOptions = new CookieOptions();
                cookieOptions.Expires = new DateTimeOffset(DateTime.Now.AddDays(-1));
                Response.Cookies.Delete("emplId", cookieOptions);
                Response.Cookies.Delete("name", cookieOptions);
                Response.Cookies.Delete("lastname", cookieOptions);
                Response.Cookies.Delete("rol", cookieOptions);
                
            }

        }
        public IActionResult LogOut(int? id)
        {
            CookieOptions cookieOptions = new CookieOptions();
            cookieOptions.Expires = new DateTimeOffset(DateTime.Now.AddDays(-1));
            if (Request.Cookies["emplId"] != null)
            {
                Response.Cookies.Delete("emplId", cookieOptions);
                Response.Cookies.Delete("name", cookieOptions);
                Response.Cookies.Delete("lastname", cookieOptions);
                Response.Cookies.Delete("rol", cookieOptions);
            }
            return RedirectToAction("Index","Cliente");
        }
    }
}
