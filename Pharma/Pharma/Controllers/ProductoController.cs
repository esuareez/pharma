using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Pharma.Models;
using System.Collections.Generic;
using System.IO;
using System.Linq;

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
        public IActionResult Create(Producto producto, IFormFile Image)
        {
            
            if (ModelState.IsValid)
            {
                var prod = _context.Productos.Where(s => s.Nombre == producto.Nombre && s.Laboratorio == producto.Laboratorio);
                if(prod.Any())
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

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Producto producto, IFormFile Image)
        {
            
            if(Image != null)
            {
                using (var ms = new MemoryStream())
                {
                    Image.CopyTo(ms);
                    producto.Img = ms.ToArray();
                }
            }
                
            _context.Productos.Update(producto);
            _context.SaveChanges();
            return RedirectToAction("Products");
            
          
        }



    }
}
