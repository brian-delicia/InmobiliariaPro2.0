using System.ComponentModel.DataAnnotations;
namespace InmobiliariaPro2.Models
{ public enum ConceptoPago
    {
        Senia = 1,
        PagoParcial=2,
       PagoTotal = 3,
        Multa = 4

    }



    public enum MedioPago
    {
        Efectivo= 1,
        Debito= 2,
        Credito=3,
        Transferencia=4
    }



    public class Pago
    {
         public int IdPago { get; set; }

        [Required(ErrorMessage = "El importe es obligatorio.")]
        [Range(1, int.MaxValue, ErrorMessage = "El importe debe ser mayor a 0.")]
        public decimal Importe { get; set; } 

        [Required(ErrorMessage = "La fecha de pago es obligatoria.")]
        public DateTime FechaPago { get; set; } = DateTime.Now;

        public ConceptoPago ConceptoPago { get; set; } 

        public MedioPago MedioPago { get; set; }

        [Required]
        public int IdReserva { get; set; }
        public Reserva? Reserva { get; set; }

        public bool Estado { get; set; } = true; 

        // Campos de auditoría 
        public int IdUsuarioCreador { get; set; }
        public Usuario? UsuarioCreador { get; set; }

        public int? IdUsuarioAnulador { get; set; }
        public Usuario? UsuarioAnulador { get; set; }
    }
}