using System.ComponentModel.DataAnnotations;

namespace ExamenPOO_U2.Dtos.DetailSheet
{
    public class DetailSheetCreateDto
    {
        [Display(Name = "Salario Base")]
        public decimal SalarioBase { get; set; }

        [Display(Name = "Horas Extras")]
        public decimal HorasExtra { get; set; }

        [Display(Name = "Monto de Horas Extras")]
        public decimal MontoHorasExtra { get; set; }

        [Display(Name = "Bonificaciones")]
        public decimal Bonificaciones { get; set; }

        [Display(Name = "Deducciones")]
        public decimal Deducciones { get; set; }

        [Display(Name = "Salario Neto")]
        public decimal SalarioNeto { get; set; }

        [Display(Name = "Comentarios")]
        public string Comentarios { get; set; }
    }
}
