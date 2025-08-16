namespace CentroEventos.Aplicacion.UseCases.Reserva.UseCases;

using CentroEventos.Aplicacion;

public class ReservaAltaUseCase(IRepositorioReserva repoReserva, IRepositorioEventoDeportivo repoEvento, IRepositorioPersona repoPersona, IServicioAutorizacion autorizacion)
{
    public void Ejecutar(Reserva reserva, int IdUsuario)
    {
        if (!autorizacion.PoseeElPermiso(IdUsuario, Permiso.ReservaAlta)) throw new FalloAutorizacionException();
        if (!repoPersona.ExisteId(reserva.PersonaId) || !repoEvento.ExisteId(reserva.EventoDeportivoId)) throw new EntidadNotFoundException("No existe la persona o el evento.");
        if (!repoEvento.HayCupo(reserva.EventoDeportivoId)) throw new CupoExcedidoException();
        if (repoReserva.ExisteReserva(reserva.PersonaId)) throw new DuplicadoException("Esa persona ya tiene una reserva.");
        reserva.EstadoAsistencia = Estado.Pendiente;
        reserva.FechaAltaReserva = DateTime.Now;
        repoReserva.DarAlta(reserva);
    }
}