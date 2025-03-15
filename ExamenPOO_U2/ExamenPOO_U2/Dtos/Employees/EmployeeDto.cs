using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ExamenPOO_U2.Dtos.Employees
{
    public class EmployeeDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Document { get; set; }
        public DateTime DateContratacion { get; set; }
        public string Department { get; set; }
        public int JobPosition { get; set; }
        public decimal BaseSalary { get; set; }
        public bool Active { get; set; }
    }
}
