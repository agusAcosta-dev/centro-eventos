namespace CentroEventos.Aplicacion.UseCases.Reserva.UseCases;

public class ListarReservaUseCase(IRepositorioReserva repo)
{
    public List<Aplicacion.Reserva> Ejecutar()
    {
        return repo.Listar();
    }
}