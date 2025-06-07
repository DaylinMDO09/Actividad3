using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;
namespace Actividad3LengProg3.Models
{
    public class EstudianteViewModel
    {
        [Required(ErrorMessage = "El nombre del estudiante es necesario")]
        [StringLength(100)]
        [Display(Name = "Nombre completo")]
        public string nombreEstudiante { get; set; }

        [Required(ErrorMessage = "La matricula es obligatória")]
        [StringLength(20, MinimumLength = 6)]
        [Display(Name = "Matricula")]
        public string matriculaEstudiante { get; set; }

        [Required(ErrorMessage = "Debes de elegir una carrera")]
        [Display (Name = "Carrera")]
        public string carreraEstudiante { get; set; }
        public List<SelectListItem> carreras { get; } = new List<SelectListItem>
        {
            new SelectListItem {Value = "Ingeniería en software", Text = "Ingeniería en software"},
            new SelectListItem {Value = "Odontología", Text = "Odontología"},
            new SelectListItem {Value = "Administración de empresas", Text = "Administración de empresas"},
            new SelectListItem {Value = "Enfermería", Text = "Enfermería"},
            new SelectListItem {Value = "Psicología", Text = "Psicología"}
        };

        [Required (ErrorMessage = "El correo es obligatorio")]
        [EmailAddress (ErrorMessage = "Correo inválido")]
        [Display (Name = "Correo institucional")]
        public string correoEstudiante { get; set; }

        [Phone]
        [MinLength(10)]
        [Display(Name = "Número telefónico")]
        public string telefonoEstudiante { get; set; }

        [Required (ErrorMessage = "Debe indicar su fecha de nacimiento")]
        [DataType (DataType.Date)]
        [Display (Name = "Fecha de nacimiento")]
        public DateTime? fechaEstudiante { get; set; }

        [Required]
        [Display (Name = "Género")]
        public string generoEstudiante { get; set; }
        
        [Required (ErrorMessage = "Debes elegir un turno")]
        [Display (Name = "Turnos")]
        public string turnoEstudiante { get; set; }
        public List<SelectListItem> turnos { get; } = new List<SelectListItem>
        {
            new SelectListItem {Value = "Matutino", Text = "Matutino"},
            new SelectListItem {Value = "Vespertino", Text = "Vespertino"},
            new SelectListItem {Value = "Nocturno", Text = "Nocturno"}
        };



    }
}
