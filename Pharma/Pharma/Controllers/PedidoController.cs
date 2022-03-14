using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Pharma.Models;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Pharma.Controllers
{
    public class PedidoController : Controller
    {
        private readonly FarmaciaContext _context;
        public PedidoController(FarmaciaContext context)
        {
            _context = context;
        }
        public IActionResult Cart()
        {
            IEnumerable<PedidoProducto> listProducto = _context.PedidoProductos;
            foreach(var product in listProducto)
            {
                product.IdproductoNavigation = _context.Productos.Find(product.Idproducto);
                product.IdpedidoNavigation = _context.Pedidos.Find(product.Idpedido);
            }
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
                return RedirectToAction("Cart","Pedido");
            }
            return RedirectToAction("Cart", "Pedido");
        }

        [HttpPost]
        [AllowAnonymous]
        public IActionResult Update(string[] cantidad, string[] idproducto)
        {
            return RedirectToAction("Cart", "Pedido");
        }

    }
}
