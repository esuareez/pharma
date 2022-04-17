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

    }
}
