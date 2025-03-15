using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ExamenPOO_U2.Database.Entities
{
    [Table("planilla")]
    public class PlanillaEntity
    {
        [Key]
        [Column("id")]
        public Guid Id { get; set; }

        [Column("period")]
        [Required]
        public string Period { get; set; }

        [Column("creation_date")]
        public DateTime CreationDate { get; set; }

        [Column("payment_date")]
        public DateTime PaymentDate { get; set; }

        [Column("state")]
        public string State { get; set; }

    }
}
