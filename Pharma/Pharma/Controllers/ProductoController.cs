using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Pharma.Models;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Pharma.Extensions;


namespace Pharma.Controllers
{
    public class ProductoController : BaseController
    {
        private readonly FarmaciaContext _context;
        public ProductoController(FarmaciaContext context)
        {
            _context = context;
        }
        public ActionResult Products()
        { 
            IEnumerable<Producto> listProducto = _context.Productos;
            IEnumerable<OrdenProducto> ordenCompras = _context.OrdenProductos;
            IEnumerable<PedidoProducto> listPedidos = _context.PedidoProductos;
            ViewBag.PedidoProducto = listPedidos;
            ViewBag.OrdenProducto = ordenCompras;
            return View(listProducto);
        }

        public ActionResult ProductsDLTD()
        {
            IEnumerable<Producto> listProducto = _context.Productos;
            IEnumerable<OrdenProducto> ordenCompras = _context.OrdenProductos;
            IEnumerable<PedidoProducto> listPedidos = _context.PedidoProductos;
            ViewBag.PedidoProducto = listPedidos;
            ViewBag.OrdenProducto = ordenCompras;
            return View(listProducto);
        }


        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken] // que un bot no pueda enviar muchas request
        public IActionResult Create(Producto producto, IFormFile Image)
        {

            if (ModelState.IsValid)
            {
                var prod = _context.Productos.Where(s => s.Nombre == producto.Nombre && s.Laboratorio == producto.Laboratorio);
                if (prod.Any())
                {
                    //TempData["mensaje"] = "Ya existe un producto de este laboratorio.";
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
                    BasicNotification("Producto creado", NotificationType.Success, "Producto creado correctamente.");
                    _context.SaveChanges();
                    return RedirectToAction("Products");
                }

            }
            return View("Products");
        }

        public IActionResult Edit(int? id)
        {

            if (id == null || id == 0)
            {
                return NotFound();
            }
            // Obtener cliente

            var producto = _context.Productos.Find(id);


            if (producto == null)
            {
                return NotFound();
            }

            return View(producto);
        }

        public void Remove(int? id)
        {
            var producto = _context.Productos.Find(id);
            producto.Estado = 3;
            _context.Productos.Update(producto);
            //TempData["mensaje"] = producto.Nombre+" ha sido eliminado correctamente.";
            BasicNotification("Producto eliminado", NotificationType.Success, producto.Nombre+" ha sido eliminado correctamente.");
            _context.SaveChanges();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Producto producto, IFormFile Image)
        {

            if (Image != null)
            {
                using (var ms = new MemoryStream())
                {
                    Image.CopyTo(ms);
                    producto.Img = ms.ToArray();
                }
                _context.Productos.Update(producto);
            }
            else
            {
                _context.Productos.Update(producto);
                _context.Entry(producto).Property(o => o.Img).IsModified = false;
            }
            BasicNotification("Producto editado", NotificationType.Success, producto.Nombre + " ha sido actualizado correctamente.");
            _context.SaveChanges();
            return RedirectToAction("Products");


        }

        public IActionResult addCart(int id)
        {
           
            if (HttpContext.Request.Cookies["userId"] != null)
            {
                int idUser = int.Parse(HttpContext.Request.Cookies["userId"]);
                var pedido = _context.Pedidos.Where(s => s.Estado == 1 && s.IdCliente == idUser).FirstOrDefault();
                if (pedido != null)
                {
                    var pedprod = _context.PedidoProductos.Where(s => s.Idpedido == pedido.IdPedido && s.Idproducto == id); //Si el producto existe en el pedido, retorna al carrito.
                    if (pedprod.Any())
                    {
                        return RedirectToAction("Cart", "Pedido");
                    }
                    else
                    {
                        PedidoProducto pp = new PedidoProducto();
                        pp.Idproducto = id;
                        pp.Idpedido = pedido.IdPedido;
                        pp.Cantidad = 1;
                        _context.PedidoProductos.Add(pp);
                    }
                }
                else
                {
                    Pedido _pedido = new Pedido();
                    _pedido.Estado = 1;
                    _pedido.IdCliente = idUser;
                    _context.Pedidos.Add(_pedido);
                    _context.SaveChanges();

                    var _pedi = _context.Pedidos.Where(s => s.Estado == 1 && s.IdCliente == idUser).FirstOrDefault();
                    PedidoProducto pp = new PedidoProducto();
                    pp.Idproducto = id;
                    pp.Idpedido = _pedi.IdPedido;
                    pp.Cantidad = 1;
                    _context.PedidoProductos.Add(pp);
                }
                _context.SaveChanges();
                return RedirectToAction("Shop", "Cliente");
            }
            else
            {
                return RedirectToAction("Login","Cliente");
            }
            
        }

        public void Recovery(int? id)
        {
            var producto = _context.Productos.Find(id);
            producto.Estado = 1;
            _context.Productos.Update(producto);
            _context.SaveChanges();
            BasicNotification("Producto recuperado", NotificationType.Success, producto.Nombre + " ha sido recuperado correctamente y ya lo puedes ver en la lista de productos.");
        }

    }
}

