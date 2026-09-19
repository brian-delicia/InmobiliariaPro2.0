namespace InmobiliariaPro2.Models
{
    public interface IRepositorioUsuario : IRepositorio<Usuario>
{
    Usuario? ObtenerPorUserName(string userName);
}
}