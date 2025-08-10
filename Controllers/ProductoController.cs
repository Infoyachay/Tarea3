using Microsoft.AspNetCore.Mvc;
using Tarea3Brandon.Models;

namespace Tarea3Brandon.Controllers
{
    public class ProductoController : Controller
    {
        private static List<Producto> productos = new List<Producto>();

        public IActionResult Index()
        {
            return View(productos);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Producto producto)
        {
            if (ModelState.IsValid)
            {
                producto.Id = productos.Count + 1;
                productos.Add(producto);
                return RedirectToAction("Index");
            }
            return View(producto);
        }
    }
}
