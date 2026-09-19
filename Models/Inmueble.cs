using System.ComponentModel.DataAnnotations;
namespace InmobiliariaPro2.Models
{
    public class Inmueble
    {   

        public int IdInmueble{get;set;}

        [Required (ErrorMessage ="La direccion es Requerida")]
        public string? Direccion{get;set;}
        [Range(1,int.MaxValue ,ErrorMessage ="La capasidad debe ser minimo 1")]
        public int Capacidad {get;set;}

        public TipoInmueble TipoInmueble{get; set;}=new TipoInmueble();
        [Required(ErrorMessage ="Debe seleccionar un tipo de inmueble")]
        public int IdTipoInmueble{get;set;}

        [Required(ErrorMessage = "La latitud debe estar entre -90 y 90")]
        [Range(-90, 90, ErrorMessage = "La latitud debe ser entre -90 y 90")]
        public decimal Latitud{get;set;}

        [Required(ErrorMessage = "La longitud debe estar entre -180 y 180")]
        [Range(-180, 180, ErrorMessage = "La longitud debe ser entre -180 y 180")]
        public decimal Longitud{get;set;}

        [Required(ErrorMessage ="El precio del alquiler es requerido")]
        [Range(1000,int.MaxValue,ErrorMessage ="El precio no puede ser menor a $1000")]
        public decimal PrecioAlquiler {get;set;}
        [Required(ErrorMessage ="Debe seleccionar un propietario")]
        public int IdPropietario{get;set;}

        public Propietario propietario {get;set;} =new Propietario();
        [Required(ErrorMessage ="Debe elegir un porcentaje")]
        [Range(10,100,ErrorMessage ="El porcentaje se debe encontrar entre el 10% y 100%")]
        public decimal PorcentajeReserva{get;set;}

        public string? ImagenUrl{get;set;}

        public IFormFile? ImagenPortada {get;set;}

        public IList<Imagen> ListaImagenes {get;set;}=new List<Imagen>(); 

        public int CantidadReservas {get;set;}

        public IList<Reserva>ListaReservas {get;set;}=new List<Reserva>();

        public bool Estado {get;set;}=true;

 

    }
}