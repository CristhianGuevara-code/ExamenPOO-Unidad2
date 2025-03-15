using System.ComponentModel.DataAnnotations.Schema;

namespace ExamenPOO_U2.Dtos.DetailSheet
{
    public class DetailSheetDto
    {
        public Guid Id { get; set; }
        public decimal SalarioBase { get; set; }
        public decimal HorasExtra { get; set; }
        public decimal MontoHorasExtra { get; set; }
        public decimal Bonificaciones { get; set; }
        public decimal Deducciones { get; set; }
        public decimal SalarioNeto { get; set; }
        public string Comentarios { get; set; }
    }
}
