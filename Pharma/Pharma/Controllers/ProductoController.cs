using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Pharma.Models;
using System.Collections.Generic;
using System.Web.Mvc;

namespace Pharma.Controllers
{
    public class ProductoController : Controller
    {
        private readonly FarmaciaContext _context;
        public ProductoController(FarmaciaContext context)
        {
            _context = context;
        }
        public ActionResult Products()
        {
            IEnumerable<Producto> listProducto = _context.Productos;
            return View(listProducto);
        }


        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken] // que un bot no pueda enviar muchas request
        public IActionResult Create(Producto producto)
        {
            if (ModelState.IsValid)
            {   
                _context.Productos.Add(producto);
                _context.SaveChanges();
                return RedirectToAction("Products");
            }
            return View("Products");
        }

    }
}
