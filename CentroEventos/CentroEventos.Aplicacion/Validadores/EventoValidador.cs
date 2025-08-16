namespace CentroEventos.Aplicacion;

public class EventoValidador
{
    public bool Validar(EventoDeportivo evento)
    {
        if (string.IsNullOrWhiteSpace(evento.Nombre) || string.IsNullOrWhiteSpace(evento.Descripcion)) return false;
        if (evento.CupoMaximo <= 0) return false;
        if (evento.DuracionHoras <= 0) return false;
        return true;
    }
}