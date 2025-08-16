namespace CentroEventos.Aplicacion;

public interface IRepositorioReserva
{
    void DarAlta(Reserva reserva);
    void DarBaja(int Id);
    void Modificar(Reserva reserva);
    bool ExisteReserva(int id);
    List<Reserva> Listar();
    int ContarReservas(int id);
    Reserva DevolverReserva(int id);
    List<Persona> ListarAsistenciasPasadas(int id);
}