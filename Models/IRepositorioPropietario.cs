namespace InmobiliariaPro2.Models
{
    public interface IRepositorioPropietario : IRepositorio<Propietario>

{
   // IList<Propietario>BuscarPorNombre(String nombre);

     bool ObtenerPorDni(string dni);    
}
}