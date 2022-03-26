using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Pharma.Models;
using System.Collections.Generic;
using System.IO;
using System.Linq;
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
            return RedirectToAction("Orders");
        }
    }
}
