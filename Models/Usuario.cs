using System.ComponentModel.DataAnnotations;
namespace InmobiliariaPro2.Models
{
    public class Usuario
    {
        public int IdUsuario { get; set; }

        [Required(ErrorMessage = "El correo electrónico es obligatorio")]
        [EmailAddress]
        [RegularExpression(@"^[^@\s]+@[^@\s]+\.[^@\s]+$",
         ErrorMessage = " (ejemplo: usuario@dominio.com)")]
        public string? Email { get; set; } 
        [Required(ErrorMessage ="Debe ingresar un password")]

        public string Password { get; set; } = "";
        [Required(ErrorMessage ="Debe ingresar un Rol")]
        public RolUsuario RolUsuario { get; set; }

        public bool Estado { get; set; } = true;
        public List<Reserva> ListaReservas { get; set; } = new List<Reserva>();

        public string? PasswordActual { get; set; } 

        public string? NuevaPassword { get; set; } 

        public string? ConfirmarPassword { get; set; } 

        public string? Avatar { get; set; }

        public IFormFile? AvatarFile { get; set; }
    }
}