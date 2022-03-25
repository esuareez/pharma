﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Pharma.Models;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Pharma.Controllers
{
    public class ProveedorController : Controller
    {
        private readonly FarmaciaContext _context;
        public ProveedorController(FarmaciaContext context)
        {
            _context = context;
        }
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken] // que un bot no pueda enviar muchas request
        public IActionResult Create(Proveedor proveedor, IFormFile Image)
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
    }
}
