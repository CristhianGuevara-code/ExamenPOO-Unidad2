using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ExamenPOO_U2.Database.Entities
{
    [Table ("employees")]
    public class EmployeeEntity
    {
        [Key]
        [Column("id")]
        public Guid Id { get; set; }


        [Column("name")]
        [Required]
        public string Name { get; set; }

        [Column("last_name")]
        [Required]
        public string LastName { get; set; }

        [Column("document")]
        [Required]
        public string Document { get; set; }

        [Column ("date_contratacion")]
        public DateTime DateContratacion { get; set; }

        [Column("department")]
        public string Department { get; set; }

        [Column("job_position")]
        public int JobPosition { get; set; }

        [Column("base_salary")]
        public decimal BaseSalary { get; set; }

        [Column("active")]
        public bool Active { get; set; }
    }
}
