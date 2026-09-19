using System.ComponentModel.DataAnnotations;
namespace InmobiliariaPro2.Models
{
    public class TipoInmueble
    {
        
        public int IdTipoInmueble {get; set;}

        [Required (ErrorMessage ="Debe ingresar un inmueble ")]
        [RegularExpression(@"^[a-zA-ZñÑ\s]{3,}$",ErrorMessage ="Debe ingresar solo letrar,minimo 3")]
        public string? Descripcion {get; set;}

        public bool Estado {get; set;}=true;

    }
}