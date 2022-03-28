using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Pharma.Models;
using RestSharp;
using System;
using System.Collections.Generic;
using System.IO;
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
            IEnumerable<Producto> listProducto = _context.Productos;
            ViewBag.Proveedors = listProveedor;
            ViewBag.Productos = listProducto;
            return View();
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
            return RedirectToAction("SelecProducto");
        }

        public IActionResult Cart(int idp, int cantidad)
        {
            var ordencompra = _context.OrdenCompras.Where(s => s.Estado == 0).FirstOrDefault();
            OrdenProducto ordenProducto = new OrdenProducto();
            ordenProducto.IdOc = ordencompra.IdOrComp;
            ordenProducto.Cantidad = cantidad;  
            ordenProducto.IdProducto = idp;
            _context.OrdenProductos.Add(ordenProducto);
            _context.SaveChanges();
            return RedirectToAction("SelecProducto");
        }

        public IActionResult SelecProducto()
        {
            var ordencompra = _context.OrdenCompras.Where(s => s.Estado == 0).FirstOrDefault();
            ViewBag.OrdenCompra = ordencompra.IdOrComp;
            IEnumerable<Producto> listProducto = _context.Productos;
            IEnumerable<OrdenProducto> ordenProductos = _context.OrdenProductos;
            ViewBag.Productos = listProducto;
            return View(ordenProductos);
        }

        public IActionResult Remove(int idp)
        {
            var ordencompra = _context.OrdenCompras.Where(s => s.Estado == 0).FirstOrDefault();
            var pd = _context.OrdenProductos.Find(ordencompra.IdOrComp, idp);
            _context.OrdenProductos.Remove(pd);
            _context.SaveChanges();
            return RedirectToAction("SelecProducto");
        }
        public IActionResult EndOC()
        {
            var ordencompra = _context.OrdenCompras.Where(s => s.Estado == 0).FirstOrDefault();
            ordencompra.Estado = 1;
            
            IEnumerable<OrdenProducto> ordenProductos = _context.OrdenProductos;
            foreach (var item in ordenProductos)
            {
                item.IdProductoNavigation = _context.Productos.Find(item.IdProducto);
                if (ordencompra.IdOrComp == item.IdOc)
                {
                    ordencompra.MontoPagar += (item.Cantidad * item.IdProductoNavigation.PrecioCompra);
                }
            }
            _context.OrdenCompras.Update(ordencompra);
            _context.SaveChanges();
            return RedirectToAction("Orders");
        }

        public ActionResult CreateProduct()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken] // que un bot no pueda enviar muchas request
        public IActionResult CreateProduct(Producto producto, IFormFile Image)
        {

            if (ModelState.IsValid)
            {
                var prod = _context.Productos.Where(s => s.Nombre == producto.Nombre && s.Laboratorio == producto.Laboratorio);
                if (prod.Any())
                {
                    TempData["mensaje"] = "Ya existe un producto de este laboratorio.";
                }
                else
                {
                    using (var ms = new MemoryStream())
                    {
                        Image.CopyTo(ms);
                        producto.Img = ms.ToArray();
                    }
                    _context.Productos.Add(producto);
                    _context.SaveChanges();
                    return RedirectToAction("SelecProducto");
                }

            }
            return View("SelecProducto");
        }

        public IActionResult CreateProveedor()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken] // que un bot no pueda enviar muchas request
        public IActionResult CreateProveedor(Proveedor proveedor, IFormFile Image)
        {

            if (ModelState.IsValid)
            {
                var ordn = _context.Proveedors.Where(s => s.Nombre == proveedor.Nombre);
                if (ordn.Any())
                {
                    TempData["mensaje"] = "Ya existe este proveedor.";
                }
                else
                {
                    using (var ms = new MemoryStream())
                    {
                        Image.CopyTo(ms);
                        proveedor.Img = ms.ToArray();
                    }
                    _context.Proveedors.Add(proveedor);
                    _context.SaveChanges();
                    return RedirectToAction("SelecProveedor");
                }

            }
            return View("SelecProveedor");
        }
    }
}
