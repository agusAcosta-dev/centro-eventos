namespace CentroEventos.Aplicacion.UseCases.Reserva.UseCases;

using CentroEventos.Aplicacion;

public class ReservaModificarUseCase(IRepositorioReserva repoReserva, IRepositorioEventoDeportivo repoEvento, IRepositorioPersona repoPersona, IServicioAutorizacion autorizacion)
{
    public void Ejecutar(Reserva reserva, int IdUsuario)
    {
        if (!autorizacion.PoseeElPermiso(IdUsuario, Permiso.ReservaModificacion)) throw new FalloAutorizacionException();
        if (!repoPersona.ExisteId(reserva.PersonaId) && !repoEvento.ExisteId(reserva.EventoDeportivoId)) throw new EntidadNotFoundException("No existe la persona o el evento.");
        if (!repoEvento.HayCupo(reserva.EventoDeportivoId)) throw new CupoExcedidoException();
        repoReserva.Modificar(reserva);
    }
}