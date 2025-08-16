namespace CentroEventos.Aplicacion.UseCases.Evento;

public class EventoAltaUseCase(IRepositorioEventoDeportivo repoEvento, IRepositorioPersona repoPersona, EventoValidador validador, IServicioAutorizacion autorizacion)
{
    public void Ejecutar(EventoDeportivo evento, int IdUsuario)
    {
        if (!autorizacion.PoseeElPermiso(IdUsuario, Permiso.EventoAlta)) throw new FalloAutorizacionException();
        if (evento.FechaHoraInicio < DateTime.Now) throw new OperacionInvalidaException();
        if (!validador.Validar(evento)) throw new ValidacionException("Evento no válido.");
        if (!repoPersona.ExisteId(evento.ResponsableId)) throw new EntidadNotFoundException(evento.ResponsableId);
        repoEvento.DarAlta(evento);
    }
}