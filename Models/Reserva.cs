using System.ComponentModel.DataAnnotations;
namespace InmobiliariaPro2.Models
{
    public class Reserva : IValidatableObject
    {
          public int IdReserva { get; set; }

        [Required(ErrorMessage = "Debe seleccionar un inquilino.")]
        public int IdInquilino { get; set; }

        public Inquilino Inquilino { get; set; } = new Inquilino();

        [Required(ErrorMessage = "Debe seleccionar un inmueble.")]
        public int IdInmueble { get; set; }

        public Inmueble Inmueble { get; set; } = new Inmueble();

        [Required(ErrorMessage = "El monto diario es obligatorio.")]
        [Range(1, int.MaxValue, ErrorMessage = "El monto diario debe ser mayor a 0.")]
        public decimal MontoDiario { get; set; }

        [Required(ErrorMessage = "La fecha de inicio es obligatoria.")]
        public DateTime FechaInicio { get; set; }

        [Required(ErrorMessage = "La fecha de finalización es obligatoria.")]
        public DateTime FechaFin { get; set; }

        
        [Range(1, int.MaxValue, ErrorMessage = "La multa no puede ser menor a 0")]
        public decimal? Multa { get; set; }

        public DateTime? FechaCancelacion { get; set; }

    
        public int? IdUsuarioCancelacion { get; set; }

        public Usuario? UsuarioCancelacion { get; set; }





        public bool Estado { get; set; } = true;

        
        public int IdUsuario { get; set; }

        public Usuario Usuario { get; set; } = new Usuario();

        public List<Pago> PagosEfectuados { get; set; } = new List<Pago>();

    
    public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
    {
        if (FechaCancelacion < FechaInicio || FechaCancelacion > FechaFin)
        {
            yield return new ValidationResult(
                "La FechaCanselacon debe estar entre FechaInicio y FechaFin.",
                new[] { nameof(FechaCancelacion) }
            );
        }
    }
}
}