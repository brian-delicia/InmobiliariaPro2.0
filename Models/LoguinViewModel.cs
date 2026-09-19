using System.ComponentModel.DataAnnotations;
namespace InmobiliariaPro2.Models
{ public class LoguinViewModel{

        [Required(ErrorMessage ="el usuario es obligatorio")]
        [EmailAddress]
        [RegularExpression(@"^[^@\s]+@[^@\s]+\.[^@\s]+$",
         ErrorMessage = " (ejemplo: usuario@dominio.com)")]
        public string Email{get;set;}="";

        [Required(ErrorMessage ="La contraseña es obligatoria")]
        public string? Password{get; set;}
}
}