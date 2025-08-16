using System;

namespace CentroEventos.Aplicacion.UseCases.EventoUseCases;

public class EventoDevolverUseCase(IRepositorioEventoDeportivo repo)
{
    public EventoDeportivo Ejecutar(int id)
    {
        return repo.DevolverEvento(id);
    }
    public EventoDeportivo Ejecutar(string s)
    {
        return repo.DevolverEvento(s);
    }
}
