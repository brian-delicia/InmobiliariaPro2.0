using System.ComponentModel.DataAnnotations;
namespace InmobiliariaPro2.Models
{
    public class Inquilino{

        public int IdInquilino{get;set;}

        [Required(ErrorMessage ="Debe ingresar un Nombre")]
        [RegularExpression(@"^[a-zA-ZñÑ\s]{3,}$",
        ErrorMessage = "El Nombre solo puede tener letras ,minimo 3")]
        public string? Nombre {get;set;}

        [Required(ErrorMessage ="Debe ingresar un Apellido")]
        [RegularExpression(@"^[a-zA-ZñÑ\s]{3,}$",ErrorMessage =
        "El apellido solo debe tener letras ,minimo 3 ")]
        public string? Apellido{get;set;}

        [Required(ErrorMessage ="Debe ingrsar un dni")]
        [RegularExpression(@"^\d{7,10}$",
         ErrorMessage = "El Dni debe tener entre 7 y 10 dígitos.")]
        public string? Dni { get; set; } 

        [Required(ErrorMessage ="Debe ingresar un telefono")]
        [RegularExpression(@"^\d{10,15}$",
        ErrorMessage = "El telefono puede tener entre 10 y 15 digitos ")]
        public string? Telefono { get; set; } 

        [Required(ErrorMessage ="Debe ingresar un Email")]
        [EmailAddress]
        [RegularExpression(@"^[^@\s]+@[^@\s]+\.[^@\s]+$",
         ErrorMessage = " (ejemplo: usuario@dominio.com)")]
        public string? Email { get; set; } 

        public bool Estado { get; set; } = true;

        public List<Reserva> ListaReservas { get; set; } = new List<Reserva>();
        
    }
}