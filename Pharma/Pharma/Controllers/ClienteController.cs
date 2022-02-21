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
    public class ClienteController : Controller
    {   
        private readonly FarmaciaContext _context;
        public ClienteController(FarmaciaContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            Validate();
            return View();
        }
        public IActionResult Login()
        {
            return View();
        }

        public void Validate()
        {
            if (Request.Cookies["userId"] == null)
            {
                RedirectToAction("Login");
            }

        }

        [HttpPost]
        [ValidateAntiForgeryToken] // que un bot no pueda enviar muchas request
        public IActionResult Create(Cliente cliente)
        {
            if (ModelState.IsValid)
            {
                var _cliente = _context.Clientes.Where(s => s.Cedula == cliente.Cedula);
                if (_cliente.Any())
                {
                    //sweetalert
                }
                else
                {
                    _context.Clientes.Add(cliente);
                    _context.SaveChanges();
                    CookieOptions cookieOptions = new CookieOptions();
                    cookieOptions.Expires = new DateTimeOffset(DateTime.Now.AddDays(7));
                    HttpContext.Response.Cookies.Append("userId", cliente.Id.ToString(), cookieOptions);
                    return RedirectToAction("Index");
                }
                
            }
            return View("Login");
        }

        [HttpPost]
        [ValidateAntiForgeryToken] // que un bot no pueda enviar muchas request
        public IActionResult Login(string Cedula, string Password)
        {
            
                var _cliente = _context.Clientes.Where(s => s.Cedula == Cedula && s.Password == Password);
                if(_cliente.Any())
                {
                    var ck = _cliente.FirstOrDefault();
                    CookieOptions cookieOptions = new CookieOptions();
                    cookieOptions.Expires = new DateTimeOffset(DateTime.Now.AddDays(7));
                    HttpContext.Response.Cookies.Append("userId", ck.Id.ToString(),cookieOptions);
                    return RedirectToAction("Index");
                }
                else
                {
                    var empleado = _context.Empleados.Where(s => s.Correo == Cedula);
                    if (empleado.Any())
                    {
                        var ck = empleado.FirstOrDefault();
                        CookieOptions cookieOptions = new CookieOptions();
                        cookieOptions.Expires = new DateTimeOffset(DateTime.Now.AddDays(1));
                        HttpContext.Response.Cookies.Append("userId", ck.IdEmpleado.ToString(), cookieOptions);
                    return RedirectToAction("Dashboard", "Empleado");
                    }                
                        return View("Login");
                }
        }

        public IActionResult EditProfile(int? id)
        {

            if (id == null || id == 0)
            {
                return NotFound();
            }
            // Obtener cliente

            var cliente = _context.Clientes.Find(id);

            if (cliente == null)
            {
                return NotFound();
            }
            
            return View(cliente);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult EditProfile(Cliente cliente)
        {
            if (ModelState.IsValid)
            {

                _context.Clientes.Update(cliente);
                _context.SaveChanges();
                TempData["mensaje"] = "El usuario se ha actualizado correctamente.";
                return RedirectToAction();
            }
            return View();
        }

        //HTTP Get Delete
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteCliente(int? id)
        {
            // Obtener cliente por id

            var cliente = _context.Clientes.Find(id);

            if (cliente == null)
            {
                return NotFound();
            }


            _context.Clientes.Remove(cliente);
            _context.SaveChanges();
            CookieOptions cookieOptions = new CookieOptions();
            cookieOptions.Expires = new DateTimeOffset(DateTime.Now.AddDays(-1));
            if (Request.Cookies["userId"]!= null)
            {
               Response.Cookies.Delete("userId",cookieOptions);
            }
            TempData["mensaje"] = "El usuario se ha eliminado correctamente.";
            return RedirectToAction("Index");


        }
        public IActionResult LogOut(int? id)
        {
            CookieOptions cookieOptions = new CookieOptions();
            cookieOptions.Expires = new DateTimeOffset(DateTime.Now.AddDays(-1));
            if (Request.Cookies["userId"] != null)
            {
                Response.Cookies.Delete("userId", cookieOptions);
            }
            return RedirectToAction("Index");
        }

        public IActionResult ForgotPassword()
        {
            return View();
        }

    }
}
