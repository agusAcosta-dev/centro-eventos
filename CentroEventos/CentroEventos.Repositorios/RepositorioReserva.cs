namespace CentroEventos.Repositorios;

using CentroEventos.Aplicacion;

public class RepositorioReserva : IRepositorioReserva
{
    public void DarAlta(Reserva reserva)
    {
        using var context = new CentroEventosContext();
        context.Add(reserva);
        context.SaveChanges();
    }
    public void DarBaja(int Id)
    {
        var context = new CentroEventosContext();
        Reserva reserva = context.Reserva.Find(Id)!;
        context.Remove(reserva);
        context.SaveChanges();
    }
    public void Modificar(Reserva reserva)
    {
        using var context = new CentroEventosContext();
        Reserva reservaModificada = context.Reserva.Find(reserva.Id)!;
        reservaModificada.EstadoAsistencia = reserva.EstadoAsistencia;
        reservaModificada.EventoDeportivoId = reserva.EventoDeportivoId;
        reservaModificada.FechaAltaReserva = reserva.FechaAltaReserva;
        reservaModificada.PersonaId = reserva.PersonaId;
        context.SaveChanges();
    }
    public List<Reserva> Listar()
    {
        using var context = new CentroEventosContext();
        return context.Reserva.ToList();
    }
    public bool ExisteReserva(int id)
    {
        using var context = new CentroEventosContext();
        return context.Reserva.Any(r => r.PersonaId == id);
    }
    public int ContarReservas(int id)
    {
        using var context = new CentroEventosContext();
        return context.Reserva.Count(r => r.EventoDeportivoId == id);
    }
    public Reserva DevolverReserva(int id)
    {
        using var context = new CentroEventosContext();
        return context.Reserva.Find(id)!;
    }
    public List<Persona> ListarAsistenciasPasadas(int id)
    {
        List<Persona> lista = new List<Persona>();
        using var context = new CentroEventosContext();
        RepositorioEventoDeportivo repoEvento = new RepositorioEventoDeportivo();
        DateTime fecha = repoEvento.DevolverEvento(id).FechaHoraInicio;
        if (fecha < DateTime.Today) return lista;
        var personasId = context.Reserva
                    .Where(r => r.EventoDeportivoId == id)
                    .Select(r => r.PersonaId)
                    .Distinct()
                    .ToList();
        lista = context.Persona
                        .Where(p => personasId.Contains(p.Id))
                        .ToList();
        context.SaveChanges();
        return lista;

    }
}