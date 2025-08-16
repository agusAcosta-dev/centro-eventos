namespace CentroEventos.Aplicacion.UseCases.Evento;

public class EventoBajaUseCase(IRepositorioEventoDeportivo repoEvento, IRepositorioReserva repoReserva, IServicioAutorizacion autorizacion)
{
    public void Ejecutar(int idEliminar, int IdUsuario)
    {
        if (!autorizacion.PoseeElPermiso(IdUsuario, Permiso.EventoBaja)) throw new FalloAutorizacionException();
        if (repoReserva.ContarReservas(idEliminar) > 0) throw new OperacionInvalidaException();
        repoEvento.DarBaja(idEliminar);
    }
}