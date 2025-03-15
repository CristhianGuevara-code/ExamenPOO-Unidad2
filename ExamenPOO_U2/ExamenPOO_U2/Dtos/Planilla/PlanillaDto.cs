using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ExamenPOO_U2.Dtos.Planilla
{
    public class PlanillaDto
    {
        public Guid Id { get; set; }
        public string Period { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime PaymentDate { get; set; }
        public string State { get; set; }
    }
}
