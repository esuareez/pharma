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
    public class ClienteController : BaseController
    {   
        private readonly FarmaciaContext _context;
        public ClienteController(FarmaciaContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            IEnumerable<Producto> listProducto = _context.Productos;
            return View(listProducto);
        }

        public IActionResult About()
        {
           
            return View();
        }
        public IActionResult Login()
        {
            ViewBag.data = "right-panel-active";
            return View();
        }

        public IActionResult CreateNC()
        {
            ViewBag.data = "";
            return View("Login");
        }

        

        [HttpPost]
        [ValidateAntiForgeryToken] // que un bot no pueda enviar muchas request
        public IActionResult Create(Cliente cliente)
        {
            if (ModelState.IsValid)
            {
                var _cliente = _context.Clientes.Where(s => s.Cedula == cliente.Cedula || s.Correo == cliente.Correo);
                var _client = _context.Empleados.Where(s => s.Cedula == cliente.Cedula || s.Correo == cliente.Correo);
                if (_cliente.Any() || _client.Any())
                {
                    BasicNotification("Error", NotificationType.Error, "Ya existe una cuenta con esta cédula o correo.");
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
            
                var _cliente = _context.Clientes.Where(s => (s.Cedula == Cedula || s.Correo == Cedula) && s.Password == Password);
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
                    var empleado = _context.Empleados.Where(s => (s.Correo == Cedula || s.Cedula == Cedula) && s.Password == Password);
                    if (empleado.Any())
                    {
                        var ck = empleado.FirstOrDefault();
                        CookieOptions cookieOptions = new CookieOptions();
                        cookieOptions.Expires = new DateTimeOffset(DateTime.Now.AddDays(1));
                        HttpContext.Response.Cookies.Append("emplId", ck.IdEmpleado.ToString(), cookieOptions);
                        HttpContext.Response.Cookies.Append("name", ck.Nombre, cookieOptions);
                        HttpContext.Response.Cookies.Append("lastname", ck.Apellido, cookieOptions);
                        HttpContext.Response.Cookies.Append("rol", ck.Puesto, cookieOptions);
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
                BasicNotification("Actualizar perfíl", NotificationType.Success, "Perfíl actualizado correctamente.");
                return RedirectToAction();
            }
            return View();
        }

        //HTTP Get Delete
        
        public IActionResult Remove(int? id)
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
            BasicNotification("Eliminar cuenta", NotificationType.Success, "Cuenta eliminada correctamente.");
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

        public IActionResult Shop()
        {
            IEnumerable<Producto> listProducto = _context.Productos;
            return View(listProducto);
        }

        public IActionResult Historial(int id)
        {
            IEnumerable<Factura> listFactura = _context.Facturas;
            foreach (var item in listFactura)
            {
                item.IdPedidoNavigation = _context.Pedidos.Find(item.IdPedido);
                if (item.IdPedidoNavigation.IdCliente == int.Parse(HttpContext.Request.Cookies["userId"]))
                {
                    item.Total = item.Monto + item.Impuesto;
                }
            }
            return View(listFactura);
        }

    }
}
