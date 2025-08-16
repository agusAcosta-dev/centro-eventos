namespace CentroEventos.Aplicacion.UseCases.PersonaUseCases;

public class PersonaDevolverUseCase(IRepositorioPersona repo)
{
    public Persona Ejecutar(int id)
    {
        if (!repo.ExisteId(id)) throw new EntidadNotFoundException(id);
        return repo.DevolverPersona(id);
    }
    public Persona Ejecutar(string id)
    {
        if (!repo.ExisteDNIoEmail(id)) throw new EntidadNotFoundException(id);
        return repo.DevolverPersona(id);
    }
}
