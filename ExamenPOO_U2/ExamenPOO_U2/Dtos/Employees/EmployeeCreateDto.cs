using System.ComponentModel.DataAnnotations;

namespace ExamenPOO_U2.Dtos.Employees
{
    public class EmployeeCreateDto
    {
        [Display(Name = "Nombres")]
        [Required(ErrorMessage = "El campo {0} es requerido")]
        public string Name { get; set; }

        [Display(Name = "Apellidos")]
        [Required(ErrorMessage = "El campo {0} es requerido")]
        public string LastName { get; set; }

        [Display(Name = "Documento Nacional de Identidad")]
        [Required(ErrorMessage = "El campo {0} es requerido")]
        public string Document { get; set; }

        [Display(Name = "Fecha de Contratacion")]
        public DateTime DateContratacion { get; set; }

        [Display(Name = "Departamento")]
        public string Department { get; set; }

        [Display(Name = "Puesto de Trabajo")]
        public int JobPosition { get; set; }

        [Display(Name = "Salario Base")]
        public decimal BaseSalary { get; set; }

        [Display(Name = "Activo")]
        public bool Active { get; set; }
    }
}
