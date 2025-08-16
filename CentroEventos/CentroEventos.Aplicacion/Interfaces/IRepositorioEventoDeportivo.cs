namespace CentroEventos.Aplicacion;

public interface IRepositorioEventoDeportivo
{
    void DarAlta(EventoDeportivo evento);
    void DarBaja(int Id);
    void Modificar(EventoDeportivo evento);
    bool ExisteId(int id);
    List<EventoDeportivo> Listar();
    bool HayCupo(int id);
    bool EsResponsable(int id);
    List<EventoDeportivo> EventosFuturos();
    EventoDeportivo DevolverEvento(int id);
    EventoDeportivo DevolverEvento(string s);
}