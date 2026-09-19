namespace InmobiliariaPro2.Models
{
     public interface IRepositorioPago : IRepositorio<Pago>
    {
        
        IList<Pago> ObtenerPorReserva(int idReserva);

       
        int ModificarConcepto(int idPago, ConceptoPago nuevoConcepto);

       
        int Anular(int idPago, int idUsuarioAnulador);
    }
}