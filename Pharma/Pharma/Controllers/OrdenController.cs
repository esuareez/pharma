using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Pharma.Models;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Pharma.Controllers
{
    public class OrdenController : Controller
    {
        private readonly FarmaciaContext _context;
        public OrdenController(FarmaciaContext context)
        {
            _context = context;
        }
        public IActionResult Orders()
        {
            IEnumerable<OrdenCompra> listOrden = _context.OrdenCompras;
            return View(listOrden);
        }
    }
}
