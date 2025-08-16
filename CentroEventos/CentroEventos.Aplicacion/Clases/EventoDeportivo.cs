namespace CentroEventos.Aplicacion;

public class EventoDeportivo
{
    public int Id { get; private set; }
    public string? Nombre { set; get; }
    public string? Descripcion { set; get; }
    public DateTime FechaHoraInicio { set; get; }
    public double DuracionHoras { set; get; }
    public int CupoMaximo { set; get; }
    public int ResponsableId { set; get; }
    public EventoDeportivo() { }
    public EventoDeportivo(EventoDeportivo evento)
    {
        Id = evento.Id;
        Nombre = evento.Nombre;
        Descripcion = evento.Descripcion;
        FechaHoraInicio = evento.FechaHoraInicio;
        DuracionHoras = evento.DuracionHoras;
        ResponsableId = evento.ResponsableId;
        CupoMaximo = evento.CupoMaximo;
    }
    public EventoDeportivo(string nombre, string desc, DateTime fecha, double duracion, int cupo, int responsable)
    {
        Nombre = nombre;
        Descripcion = desc;
        FechaHoraInicio = fecha;
        DuracionHoras = duracion;
        CupoMaximo = cupo;
        ResponsableId = responsable;
    }
    public override string ToString()
    {
        return $"Nombre del evento: {Nombre}, descripcion: {Descripcion} - ID: {Id}\nHora de inicio: {FechaHoraInicio} - Duracion: {DuracionHoras}\nCupo Maximo: {CupoMaximo} - Responsable a cargo: {ResponsableId}";
    }
}