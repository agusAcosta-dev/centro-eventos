namespace CentroEventos.Aplicacion.UseCases.Reserva.UseCases;

public class ReservaBajaUseCase(IRepositorioReserva repoReserva, IServicioAutorizacion autorizacion)
{
    public void Ejecutar(int idEliminar, int IdUsuario)
    {
        if (!autorizacion.PoseeElPermiso(IdUsuario, Permiso.ReservaBaja)) throw new FalloAutorizacionException();
        repoReserva.DarBaja(idEliminar);
    }
}