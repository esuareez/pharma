using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Pharma.Extensions;
using Pharma.Models;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Pharma.Controllers
{
    public class PedidoController : BaseController
    {
        private readonly FarmaciaContext _context;
        public PedidoController(FarmaciaContext context)
        {
            _context = context;
        }
        public IActionResult Cart()
        {
            double total = 0;
            double itbis = 0;
            double totitbis = 0;
            IEnumerable<PedidoProducto> listProducto = _context.PedidoProductos;
            foreach (var product in listProducto)
            {
                product.IdproductoNavigation = _context.Productos.Find(product.Idproducto);
                product.IdpedidoNavigation = _context.Pedidos.Find(product.Idpedido);
                if (product.IdpedidoNavigation.IdCliente == int.Parse(HttpContext.Request.Cookies["userId"]) && product.IdpedidoNavigation.Estado == 1)
                {
                    if (product.IdproductoNavigation.Itbis != 0)
                    {
                        itbis = product.IdproductoNavigation.PrecioVenta * 0.18;
                        if (product.Cantidad > 1)
                            itbis *= product.Cantidad;
                        total += (product.IdproductoNavigation.PrecioVenta * product.Cantidad);
                        total += itbis;
                        totitbis += itbis;
                    }
                    else
                    {
                        total += (product.IdproductoNavigation.PrecioVenta * product.Cantidad);
                    }
                }
            }
            ViewBag.Total = total;
            ViewBag.Itbis = totitbis;
            return View(listProducto);
        }

        public IActionResult Remove(int id)
        {
            int idUser = int.Parse(HttpContext.Request.Cookies["userId"]);
            var pedido = _context.Pedidos.Where(s => s.Estado == 1 && s.IdCliente == idUser).FirstOrDefault();
            if(pedido != null)
            {
                var pd = _context.PedidoProductos.Find(pedido.IdPedido,id);
                _context.PedidoProductos.Remove(pd);
                _context.SaveChanges();
                BasicNotification("Pedido eliminado", NotificationType.Error, "Pedido eliminado con éxito.");
                return RedirectToAction("Cart","Pedido");
            }
            return RedirectToAction("Cart", "Pedido");
        }

        [HttpPost]
        [AllowAnonymous]
        public void Update(string[] cantidad, string[] idproducto)
        {
            int idUser = int.Parse(HttpContext.Request.Cookies["userId"]);
            int idp = 0;
            var pedido = _context.Pedidos.Where(s => s.Estado == 1 && s.IdCliente == idUser).FirstOrDefault();
            if (pedido != null)
            {
                for (int i = 0; i < idproducto.Length; i++)
                {
                    idp = int.Parse(idproducto[i]);
                    var pd = _context.PedidoProductos.Find(pedido.IdPedido,idp);
                    pd.Cantidad = int.Parse(cantidad[i]);
                    _context.PedidoProductos.Update(pd);
                    _context.SaveChanges();
                }
            }
        }

        public IActionResult Pedidos()
        {
            IEnumerable<Pedido> listPedidos = _context.Pedidos;
            foreach(var item in listPedidos)
            {
                item.IdClienteNavigation = _context.Clientes.Find(item.IdCliente);
            }
            return View(listPedidos);
        }

        public IActionResult Complete(int id)
        {
            var pedido = _context.Pedidos.Find(id);
            pedido.Estado = 3; // Estado pedido entregado
            _context.Pedidos.Update(pedido);
            _context.SaveChanges();
            BasicNotification("Pedido entregado", NotificationType.Success, "Pedido entregado con éxito.");
            return RedirectToAction("Pedidos");
        }

        public IActionResult RemovePd(int id)
        {
            var factura = _context.Facturas;
            Factura fact;
            foreach(var item in factura)
            {
                if(item.IdPedido == id)
                {
                    fact = item;
                    item.IdPedidoNavigation = _context.Pedidos.Find(item.IdPedido);
                    IEnumerable<Producto> listProductos = _context.Productos;
                    IEnumerable<PedidoProducto> pedidoprod = _context.PedidoProductos;
                    foreach (var pp in pedidoprod)
                    {
                        if(pp.Idpedido == item.IdPedido)
                        {
                            foreach (var prod in listProductos)
                            {
                                if(prod.Id == pp.Idproducto)
                                {
                                    prod.Cantidad += pp.Cantidad;
                                    _context.Productos.Update(prod);
                                }
                            }
                        }
                    }
                    _context.Facturas.Remove(fact);
                }
            }
            var pedido = _context.Pedidos.Find(id);
            pedido.Estado = 0; // Estado pedido cancelado
            _context.Pedidos.Update(pedido);
            _context.SaveChanges();
            return RedirectToAction("Pedidos");
        }

        public IActionResult View(int id)
        {
            IEnumerable<PedidoProducto> listProducto = _context.PedidoProductos;
            foreach (var item in listProducto)
            {
                item.IdproductoNavigation = _context.Productos.Find(item.Idproducto);
            }
            IEnumerable<Proveedor> proveedors = _context.Proveedors;
            var pedido = _context.Pedidos.Find(id);
            ViewBag.Pedido = pedido;
            return View(listProducto);
        }

    }
}
