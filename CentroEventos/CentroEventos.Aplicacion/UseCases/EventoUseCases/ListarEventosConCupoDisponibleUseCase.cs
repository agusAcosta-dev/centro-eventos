namespace CentroEventos.Aplicacion.UseCases.Evento;

public class ListarEventosConCupoDisponibleUseCase(IRepositorioEventoDeportivo repoEvento)
{
    public List<EventoDeportivo> Ejecutar()
    {
        return repoEvento.EventosFuturos();
    }
}