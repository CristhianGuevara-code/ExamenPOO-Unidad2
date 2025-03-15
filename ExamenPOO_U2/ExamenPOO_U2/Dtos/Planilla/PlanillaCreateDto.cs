using System.ComponentModel.DataAnnotations;

namespace ExamenPOO_U2.Dtos.Planilla
{
    public class PlanillaCreateDto
    {
        [Display(Name = "Periodo")] // Por ejemplo Marzo 2025
        [Required (ErrorMessage = "El campo {0} es requerido")]
        public string Period { get; set; }

        [Display(Name = "Fecha de Creacion")]
        public DateTime CreationDate { get; set; }

        [Display(Name = "Fecha de Pago")]
        public DateTime PaymentDate { get; set; }

        [Display(Name = "Estado")] // Pendiente, Pagada, Anulada
        public string State { get; set; }
    }
}
