namespace CentroEventos.Aplicacion.UseCases.ReservaUseCases;

public class ReservaDevolverUseCase(IRepositorioReserva repo)
{
    public Aplicacion.Reserva Ejecutar(int id)
    {
        return repo.DevolverReserva(id);
    }
}
