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
    public class FacturaController : BaseController
    {
        private readonly FarmaciaContext _context;
        public FacturaController(FarmaciaContext context)
        {
            _context = context;
        }
        public IActionResult Factura()
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
            ViewBag.itbis = totitbis;
            var pedido = _context.Pedidos.Where(s => s.IdCliente == int.Parse(HttpContext.Request.Cookies["userId"]) && s.Estado == 1).FirstOrDefault();
            ViewBag.IdP = pedido.IdPedido;
            return View(listProducto);
        }

        public IActionResult addFactura(int idp)
        {
            var factura = new Factura();
            double total = 0;
            double itbis = 0;
            double totitbis = 0;
            Producto pd = new Producto();
            factura.IdPedido = idp;
            IEnumerable<PedidoProducto> listProducto = _context.PedidoProductos;
            foreach (var product in listProducto)
            {
                product.IdproductoNavigation = _context.Productos.Find(product.Idproducto);
                product.IdpedidoNavigation = _context.Pedidos.Find(product.Idpedido);
                if (product.IdpedidoNavigation.IdCliente == int.Parse(HttpContext.Request.Cookies["userId"]) && product.IdpedidoNavigation.IdPedido == idp)
                {
                    if (product.IdproductoNavigation.Itbis != 0)
                    {
                        itbis = product.IdproductoNavigation.PrecioVenta * 0.18;
                        total += (product.IdproductoNavigation.PrecioVenta * product.Cantidad);
                        total += itbis;
                        totitbis += itbis;
                    }
                    else
                    {
                        total += (product.IdproductoNavigation.PrecioVenta * product.Cantidad);
                    }
                    pd = _context.Productos.Find(product.Idproducto);
                    pd.Cantidad -= product.Cantidad;
                    _context.Productos.Update(pd);
                }
            }
            factura.Impuesto = itbis;
            factura.FechaFactura = System.DateTime.Today;
            factura.IdTipoPago = 1;
            factura.Monto = total - itbis;
            var pedido = _context.Pedidos.Find(idp);
            pedido.Estado = 2;
            _context.Facturas.Add(factura);
            _context.Pedidos.Update(pedido);
            _context.SaveChanges();
            return RedirectToAction("Cart","Pedido");
        }
    }
}
