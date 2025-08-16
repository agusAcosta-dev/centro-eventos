namespace CentroEventos.Aplicacion.UseCases.Evento;

public class EventoModificarUseCase(IRepositorioEventoDeportivo repoEvento, IServicioAutorizacion autorizacion, EventoValidador validador)
{
    public void Ejecutar(EventoDeportivo evento, int IdUsuario)
    {
        if (!autorizacion.PoseeElPermiso(IdUsuario, Permiso.EventoModificacion)) throw new FalloAutorizacionException();
        if (evento.FechaHoraInicio < DateTime.Now) throw new OperacionInvalidaException();
        if (!validador.Validar(evento)) throw new ValidacionException("Evento no válido.");
        repoEvento.Modificar(evento);
    }
}