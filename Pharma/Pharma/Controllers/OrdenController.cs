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
    public class OrdenController : Controller
    {
        private readonly FarmaciaContext _context;
        public OrdenController(FarmaciaContext context)
        {
            _context = context;
        }
        public IActionResult Orders()
        {
            IEnumerable<OrdenCompra> listOrden = _context.OrdenCompras;
            foreach (var compra in listOrden)
            {
                compra.IdProveedorNavigation = _context.Proveedors.Find(compra.IdProveedor);
            }
                return View(listOrden);
        }

        public IActionResult SelecProveedor()
        {
            IEnumerable<Proveedor> listProveedor = _context.Proveedors;
            return View(listProveedor);
        }

        public IActionResult Create(int id)
        {
            OrdenCompra compra = new OrdenCompra();
            compra.IdProveedor = id;
            compra.Fecha = System.DateTime.Now.Date;
            compra.IdEmpleado = int.Parse(HttpContext.Request.Cookies["emplId"]);
            compra.MontoPagar = 0;
            compra.Estado = 0;
            _context.OrdenCompras.Add(compra);
            _context.SaveChanges();
            CookieOptions cookieOptions = new CookieOptions();
            cookieOptions.Expires = new DateTimeOffset(DateTime.Now.AddDays(1));
            HttpContext.Response.Cookies.Append("idOC", compra.IdOrComp.ToString(), cookieOptions);
            return RedirectToAction("SelecProducto");
        }

        public IActionResult Cart(int id, int idp, int cantidad)
        {
            OrdenProducto ordenProducto = new OrdenProducto();
            ordenProducto.IdOc = id;
            ordenProducto.Cantidad = cantidad;  
            ordenProducto.IdProducto = idp;
            _context.OrdenProductos.Add(ordenProducto);
            _context.SaveChanges();
            CookieOptions cookieOptions = new CookieOptions();
            cookieOptions.Expires = new DateTimeOffset(DateTime.Now.AddDays(-1));
            if (Request.Cookies["idOC"] != null)
            {
                Response.Cookies.Delete("idOC", cookieOptions);
            }
            return RedirectToAction("Orders");
        }

        public IActionResult SelecProducto()
        {
            IEnumerable<Producto> listProducto = _context.Productos;
            return View(listProducto);
        }
    }
}
