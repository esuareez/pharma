using Microsoft.AspNetCore.Mvc;
using Pharma.Models;
using System.Collections.Generic;

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
            }
            return View(listProducto);
        }

        
    }
}
