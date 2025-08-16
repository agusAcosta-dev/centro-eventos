using System;

namespace CentroEventos.Aplicacion.UseCases.ReservaUseCases;

public class ListarReservaAsistenciasUseCase(IRepositorioReserva repo)
{
    public List<Persona> Ejecutar(int id)
    {
        return repo.ListarAsistenciasPasadas(id);
    }
}
