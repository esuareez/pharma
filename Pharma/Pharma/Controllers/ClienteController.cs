using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Pharma.Models;
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
            //var user_id = HttpContext.Request.Cookies["userId"];
            return View();
        }
        public IActionResult Login()
        {
            return View();
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
                    return RedirectToAction("Index");
                }
                
            }
            return View("Login");
        }

        [HttpPost]
        [ValidateAntiForgeryToken] // que un bot no pueda enviar muchas request
        public IActionResult Login(Cliente cliente)
        {
            if (ModelState.IsValid)
            {
                var _cliente = _context.Clientes.Where(s => s.Cedula == cliente.Cedula && s.Password == cliente.Password);
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
                    return View("Login");
                }
                
            }
            return View("Login");
        }
    }
}
