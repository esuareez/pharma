using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Pharma.Models;
using System.Linq;

namespace Pharma.Controllers
{
    public class ClienteController : Controller
    {
        private readonly FarmaciaContext _context;
        public ClienteController(FarmaciaContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken] // que un bot no pueda enviar muchas request
        public IActionResult Create(Cliente cliente)
        {
            if (ModelState.IsValid)
            {
                var _cliente = _context.Clientes.Where(s => s.Cedula == cliente.Cedula);
                if (_cliente.Any())
                {
                    
                }
                else
                {
                    _context.Clientes.Add(cliente);
                    _context.SaveChanges();
                    return RedirectToAction("Index");
                }
                
            }
            return View("Login");
        }

        [HttpPost]
        [ValidateAntiForgeryToken] // que un bot no pueda enviar muchas request
        public IActionResult Login(Cliente cliente)
        {
            if (ModelState.IsValid)
            {
                var _cliente = _context.Clientes.Where(s => s.Cedula == cliente.Cedula && s.Password == cliente.Password);
                if(_cliente.Any())
                {
                    var ck = _cliente.FirstOrDefault(); 
                    return RedirectToAction("Index");
                }
                else
                {
                    return View("Login");
                }
                
            }
            return View("Login");
        }
    }
}
