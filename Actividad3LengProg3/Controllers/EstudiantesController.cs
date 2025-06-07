using Actividad3LengProg3.Models;
using Microsoft.AspNetCore.Mvc;
namespace Actividad3LengProg3.Controllers
{
    public class EstudiantesController : Controller
    {
        private static List<EstudianteViewModel> estudiantes = new List<EstudianteViewModel>();
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Registrar(EstudianteViewModel model) 
        {
            if (ModelState.IsValid)
            {
                estudiantes.Add(model);
                TempData["Mensaje"] = "Estudiante registrado correctamente.";
                return RedirectToAction("Index");
            }

            return View(model);
        }
    }
}
