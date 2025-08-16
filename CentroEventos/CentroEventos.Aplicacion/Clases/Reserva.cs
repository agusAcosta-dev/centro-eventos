namespace CentroEventos.Aplicacion;

public class Reserva
{
    public int Id { get; private set; }
    public int PersonaId { set; get; }
    public int EventoDeportivoId { set; get; }
    public DateTime FechaAltaReserva { set; get; }
    public Estado EstadoAsistencia { set; get; } = Estado.Pendiente;
    public Reserva() { }
    public Reserva(Reserva reserva)
    {
        Id = reserva.Id;
        PersonaId = reserva.PersonaId;
        EventoDeportivoId = reserva.EventoDeportivoId;
        FechaAltaReserva = reserva.FechaAltaReserva;
        EstadoAsistencia = reserva.EstadoAsistencia;
    }
    public Reserva(int idPersona, int evento)
    {
        PersonaId = idPersona;
        EventoDeportivoId = evento;
    }
    public Reserva(int idPersona, int evento, Estado estado, DateTime fecha) : this(idPersona, evento)
    {
        EstadoAsistencia = estado; FechaAltaReserva = fecha;
    }
    public override string ToString()
    {
        return $"A nombre de: {PersonaId}, al evento {EventoDeportivoId}, realizado a las {FechaAltaReserva}.\nEstado: {EstadoAsistencia} - ID: {Id}";
    }
}