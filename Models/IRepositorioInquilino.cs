namespace InmobiliariaPro2.Models
{
     public interface IRepositorioInquilino : IRepositorio<Inquilino>
    {
        IList<Inquilino> BuscarPorNombre(string nombre);

        bool ObtenerPorDni(String dni);


    }
}