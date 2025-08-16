namespace CentroEventos.Aplicacion.UseCases.Evento;

public class ListarEventoDeportivoUseCase(IRepositorioEventoDeportivo repo)
{
    public List<EventoDeportivo> Ejecutar()
    {
        return repo.Listar();
    }
}