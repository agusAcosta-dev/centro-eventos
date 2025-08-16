namespace CentroEventos.Repositorios;
using CentroEventos.Aplicacion;
public class RepositorioEventoDeportivo : IRepositorioEventoDeportivo
{
    public void DarAlta(EventoDeportivo evento)
    {
        using var context = new CentroEventosContext();
        context.Add(evento);
        context.SaveChanges();
    }
    public void DarBaja(int Id)
    {
        using var context = new CentroEventosContext();
        EventoDeportivo evento = context.Evento.Find(Id)!;
        context.Remove(evento);
        context.SaveChanges();
    }
    public void Modificar(EventoDeportivo evento)
    {
        using var context = new CentroEventosContext();
        EventoDeportivo eventoModificado = context.Evento.Find(evento.Id)!;
        eventoModificado.Nombre = evento.Nombre;
        eventoModificado.Descripcion = evento.Descripcion;
        eventoModificado.CupoMaximo = evento.CupoMaximo;
        eventoModificado.DuracionHoras = evento.DuracionHoras;
        eventoModificado.FechaHoraInicio = evento.FechaHoraInicio;
        eventoModificado.ResponsableId = evento.ResponsableId;
        context.SaveChanges();
    }
    public List<EventoDeportivo> Listar()
    {
        using var context = new CentroEventosContext();
        return context.Evento.ToList();
    }
    public List<EventoDeportivo> EventosFuturos()
    {
        using var context = new CentroEventosContext();
        return context.Evento.Where(e => e.FechaHoraInicio > DateTime.Now)
                                    .AsEnumerable()
                                    .Where(e => HayCupo(e.Id))
                                    .ToList();
    }
    public bool EsResponsable(int id)
    {
        using var context = new CentroEventosContext();
        return context.Reserva.Any(r => r.PersonaId == id);
    }
    public bool HayCupo(int id)
    {
        using var context = new CentroEventosContext();
        var evento = context.Evento.Find(id)
                ?? throw new EntidadNotFoundException($"Evento {id} no existe");
        int reservas = context.Reserva
                         .Count(r => r.EventoDeportivoId == id);
        return reservas < evento.CupoMaximo;
    }
    public bool ExisteId(int id)
    {
        return true;
    }
    public EventoDeportivo DevolverEvento(int id)
    {
        using var context = new CentroEventosContext();
        return context.Evento.Find(id)!;
    }
    public EventoDeportivo DevolverEvento(string s)
    {
        using var context = new CentroEventosContext();
        return context.Evento.FirstOrDefault(e => e.Nombre == s)!;
    }
}