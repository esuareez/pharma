﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Pharma.Extensions;
using Pharma.Models;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Pharma.Controllers
{
    public class ProveedorController : BaseController
    {
        private readonly FarmaciaContext _context;
        public ProveedorController(FarmaciaContext context)
        {
            _context = context;
        }

        public IActionResult Proveedores()
        {
            IEnumerable<Proveedor> listProveedor = _context.Proveedors;
            return View(listProveedor);
        }
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken] // que un bot no pueda enviar muchas request
        public IActionResult Create(Proveedor proveedor, IFormFile Image, int ventana)
        {

            if (ModelState.IsValid)
            {
                var ordn = _context.Proveedors.Where(s => s.Nombre == proveedor.Nombre);
                if (ordn.Any())
                {
                    TempData["mensaje"] = "Ya existe este proveedor.";
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
                    return RedirectToAction("Proveedores");
                }

            }
            return View("Proveedores");
        }


        public IActionResult Edit(int? id)
        {

            if (id == null || id == 0)
            {
                return NotFound();
            }
            // Obtener cliente

            var proveedor = _context.Proveedors.Find(id);


            if (proveedor == null)
            {
                return NotFound();
            }

            return View(proveedor);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Proveedor proveedor, IFormFile Image)
        {

            if (Image != null)
            {
                using (var ms = new MemoryStream())
                {
                    Image.CopyTo(ms);
                    proveedor.Img = ms.ToArray();
                }
                _context.Proveedors.Update(proveedor);
            }
            else
            {
                _context.Proveedors.Update(proveedor);
                _context.Entry(proveedor).Property(o => o.Img).IsModified = false;
            }

            _context.SaveChanges();
            return RedirectToAction("Proveedores");


        }

        public IActionResult Remove(int? id)
        {
            var proveedor = _context.Proveedors.Find(id);
            _context.Proveedors.Remove(proveedor);
            _context.SaveChanges();
            return RedirectToAction("Proveedores");
        }
    }
}
