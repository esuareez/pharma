using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Pharma.Models;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Pharma.Controllers
{
    public class FacturaController : Controller
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
                if (product.IdpedidoNavigation.IdCliente == int.Parse(HttpContext.Request.Cookies["userId"]))
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
            return View(listProducto);
        }
    }
}
