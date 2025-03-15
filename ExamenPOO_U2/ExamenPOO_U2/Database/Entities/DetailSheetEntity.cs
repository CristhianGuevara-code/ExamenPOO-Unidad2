using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ExamenPOO_U2.Database.Entities
{
    [Table("detalle_planilla")]
    public class DetailSheetEntity
    {
        [Key]
        [Column("id")]
        public Guid Id { get; set; }

        [Column("salario_base")]
        public decimal SalarioBase { get; set; }

        [Column("horas_extra")]
        public decimal HorasExtra { get; set; }

        [Column("monto_horas_extra")]
        public decimal MontoHorasExtra { get; set; }

        [Column("bonificaciones")]
        public decimal Bonificaciones {  get; set; }

        [Column("deducciones")]
        public decimal Deducciones { get; set; }

        [Column("salario_neto")]
        public decimal SalarioNeto { get; set; }

        [Column("comentarios")]
        public string Comentarios { get; set; }


    }
}
