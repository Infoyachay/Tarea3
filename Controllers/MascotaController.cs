using Microsoft.AspNetCore.Mvc;
using Tarea3Brandon.Models;

namespace Tarea3Brandon.Controllers
{
    public class MascotaController : Controller
    {
        private static List<Mascota> mascotas = new List<Mascota>();

        public IActionResult Index()
        {
            return View(mascotas);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Mascota mascota)
        {
            if (ModelState.IsValid)
            {
                mascota.Id = mascotas.Count + 1;
                mascotas.Add(mascota);
                return RedirectToAction("Index");
            }
            return View(mascota);
        }
    }
}
