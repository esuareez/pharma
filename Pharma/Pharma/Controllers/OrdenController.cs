using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Pharma.Extensions;
using Pharma.Models;
using RestSharp;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Claims;
namespace Pharma.Controllers
{
    public class OrdenController : BaseController
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
            var ordencompra = _context.OrdenCompras.Where(s => s.Estado == 0);
            IEnumerable<Producto> listProducto = _context.Productos;
            if (ordencompra.Any())
            {
                var oc = ordencompra.FirstOrDefault();
                    var opr = _context.OrdenProductos.Where(s => s.IdOc == oc.IdOrComp);
                    if (opr.Any())
                    {
                        foreach (var idp in listProducto)
                        {
                            
                            var pd = _context.OrdenProductos.Find(oc.IdOrComp, idp.Id);
                            if (pd != null)
                                _context.OrdenProductos.Remove(pd);
                        }

                    }
                _context.OrdenCompras.Remove(oc);
                _context.SaveChanges();
            }
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
            var pd = _context.OrdenProductos.Find(ordencompra.IdOrComp, idp);
            if(pd != null)
            {
                pd.Cantidad = cantidad;
                _context.OrdenProductos.Update(pd);
                _context.SaveChanges();
                return RedirectToAction("SelecProducto");
            }
            else
            {
                OrdenProducto ordenProducto = new OrdenProducto();
                ordenProducto.IdOc = ordencompra.IdOrComp;
                ordenProducto.Cantidad = cantidad;
                ordenProducto.IdProducto = idp;
                _context.OrdenProductos.Add(ordenProducto);
                _context.SaveChanges();
                return RedirectToAction("SelecProducto");
            }
            
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
                    BasicNotification("Producto existente", NotificationType.Error, "Ya existe un producto de este laboratorio.");
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
                    BasicNotification("Proveedor existente", NotificationType.Error, "Ya existe este proveedor.");
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

        public IActionResult EOrden(int id)
        {
            IEnumerable<OrdenProducto> listProducto = _context.OrdenProductos;
            foreach (var item in listProducto)
            {
                item.IdProductoNavigation = _context.Productos.Find(item.IdProducto);
            }
            IEnumerable<Proveedor> proveedors = _context.Proveedors;
            var orden = _context.OrdenCompras.Find(id);
            orden.IdProveedorNavigation = _context.Proveedors.Find(orden.IdProveedor);
            ViewBag.Compra = orden;
            ViewBag.Proveedors = proveedors;
            
            return View(listProducto);
        }

        [HttpPost]
        [AllowAnonymous]
        public void Update(string[] cantidad, string[] idproducto, string idc, string idpr)
        {
            int idp = 0;
            double total = 0;
            int idcc = int.Parse(idc);
            int idprv = int.Parse(idpr);
            var productos = _context.OrdenProductos.Where(s => s.IdOc == idcc).FirstOrDefault();
            if (productos != null)
            {
                for (int i = 0; i < idproducto.Length; i++)
                {
                    idp = int.Parse(idproducto[i]);
                    var pd = _context.OrdenProductos.Find(idcc, productos.IdProducto);
                    pd.Cantidad = int.Parse(cantidad[i]);
                    _context.OrdenProductos.Update(pd);
                }
            }
            var oc = _context.OrdenCompras.Find(idcc);
            oc.IdProveedor = idprv;

            IEnumerable<OrdenProducto> ordenProductos = _context.OrdenProductos;
            foreach (var item in ordenProductos)
            {
                
                item.IdProductoNavigation = _context.Productos.Find(item.IdProducto);
                if (oc.IdOrComp == item.IdOc)
                {
                   total += (item.Cantidad * item.IdProductoNavigation.PrecioCompra);
                }
            }
            oc.MontoPagar = total;
            _context.OrdenCompras.Update(oc);
            _context.SaveChanges();
        }

        public IActionResult Complete(int id)
        {
            var orden = _context.OrdenCompras.Find(id);
            orden.Estado = 2;
            _context.OrdenCompras.Update(orden);
            IEnumerable<Producto> productos = _context.Productos;
            foreach(var item in productos)
            {
                var pd = _context.OrdenProductos.Find(id, item.Id);
                if(pd != null)
                {
                    item.Cantidad += pd.Cantidad;
                    _context.Productos.Update(item);
                }
            }
            _context.SaveChanges();
            BasicNotification("Orden de compra completada", NotificationType.Success, "Orden de compra completada con éxito.");
            return RedirectToAction("Orders");
        }

        public IActionResult RemoveOC(int id)
        {
            IEnumerable<Producto> productos = _context.Productos;
            foreach (var item in productos)
            {
                var pd = _context.OrdenProductos.Find(id, item.Id);
                if (pd != null)
                {
                    _context.OrdenProductos.Remove(pd);
                }
            }
            var orden = _context.OrdenCompras.Find(id);
            _context.OrdenCompras.Remove(orden);
            _context.SaveChanges();
            BasicNotification("Orden de compra eliminada", NotificationType.Error, "Orden de compra eliminada con éxito.");
            return RedirectToAction("Orders");
        }

        public IActionResult View(int id)
        {
            IEnumerable<OrdenProducto> listProducto = _context.OrdenProductos;
            foreach (var item in listProducto)
            {
                item.IdProductoNavigation = _context.Productos.Find(item.IdProducto);
            }
            IEnumerable<Proveedor> proveedors = _context.Proveedors;
            var orden = _context.OrdenCompras.Find(id);
            orden.IdProveedorNavigation = _context.Proveedors.Find(orden.IdProveedor);
            ViewBag.Compra = orden;
            ViewBag.Proveedors = proveedors;
            
            return View(listProducto);
        }
    }

}
