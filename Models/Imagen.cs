using System.ComponentModel.DataAnnotations;
namespace InmobiliariaPro2.Models
{
    public class Imagen
    {
      
        public int IdImagen {get; set;}
        [Required]
        public string? Url {get;set;}
        [Required]
        public int IdInmueble {get;set;}
         public IFormFile? Archivo {get; set;}

     }
}