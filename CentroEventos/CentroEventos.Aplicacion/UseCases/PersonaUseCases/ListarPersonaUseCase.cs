namespace CentroEventos.Aplicacion.UseCases.PersonaUseCases;

using CentroEventos.Aplicacion;
public class ListarPersonaUseCase(IRepositorioPersona repo)
{
    public List<Persona> Ejecutar()
    {
        return repo.Listar();
    }
}