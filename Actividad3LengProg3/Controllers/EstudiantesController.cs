using Actividad3LengProg3.Models;
using Microsoft.AspNetCore.Mvc;
namespace Actividad3LengProg3.Controllers
{
    public class EstudiantesController : Controller
    {
        private static List<EstudianteViewModel> estudiantes = new List<EstudianteViewModel>();


        public IActionResult Index()
        {
            return View(new EstudianteViewModel());
        }

        [HttpPost]
        public IActionResult Registrar(EstudianteViewModel model) 
        {
            if (ModelState.IsValid)
            {
                estudiantes.Add(model);
                TempData["Mensaje"] = "Estudiante registrado correctamente.";
            }

            return View("Index", estudiantes);
        }

        [HttpPost]
        public IActionResult Editar(EstudianteViewModel model)
        {
            if (ModelState.IsValid)
            {
                EstudianteViewModel estudianteActual = estudiantes.FirstOrDefault(e => e.matriculaEstudiante.Equals(model.matriculaEstudiante));

                if (estudianteActual != null)
                {
                    TempData["MensajeError"] = "No existe el estudiante indicado.";

                    return RedirectToAction("Lista");
                }

                estudianteActual.matriculaEstudiante = model.matriculaEstudiante;
                estudianteActual.nombreEstudiante = model.nombreEstudiante;
                estudianteActual.carreraEstudiante = model.carreraEstudiante;
                estudianteActual.correoEstudiante = model.correoEstudiante;
                estudianteActual.telefonoEstudiante = model.telefonoEstudiante;
                estudianteActual.fechaEstudiante = model.fechaEstudiante;
                estudianteActual.generoEstudiante = model.generoEstudiante;
                estudianteActual.turnoEstudiante = model.turnoEstudiante.ToString();
                estudianteActual.ingresoEstudiante = model.ingresoEstudiante;
                estudianteActual.becaEstudiante = model.becaEstudiante;
                estudianteActual.porcentajebecaEstudiante = model.porcentajebecaEstudiante;

                TempData["Mensaje"] = "Los datos del estudiante han sido editados satisfactoriamente.";
                return RedirectToAction("Lista");            
            }

           return View(model); 
        }

        public IActionResult Eliminar (string matricula) 
        {
            EstudianteViewModel estudiante = new EstudianteViewModel();
            if (!ModelState.IsValid) 
            {
                estudiantes.Remove(estudiante);
            }
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Lista()
        {
            return View(estudiantes);
        }
    }
}
