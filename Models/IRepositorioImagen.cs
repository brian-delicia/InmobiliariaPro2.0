namespace InmobiliariaPro2.Models
{
    public interface IRepositorioImagen
    {
        int Alta(Imagen imagen);
        int Eliminar(int id);
        Imagen? ObtenerPorId(int id);
        IList<Imagen> ObtenerPorInmueble(int inmuebleId);
    }
}