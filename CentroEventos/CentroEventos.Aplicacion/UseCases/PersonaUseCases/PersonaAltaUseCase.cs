namespace CentroEventos.Aplicacion.UseCases.PersonaUseCases;

using CentroEventos.Aplicacion;

public class PersonaAltaUseCase(IRepositorioPersona repo, PersonaValidador validador, IServicioAutorizacion autorizacion)
{
    public void Ejecutar(Persona persona, int id)
    {
        if (!autorizacion.PoseeElPermiso(id, Permiso.PersonaAlta)) throw new FalloAutorizacionException();
        if (!validador.Validar(persona)) throw new ValidacionException("Persona no válida.");
        if (repo.ExisteDNIoEmail(persona.DNI) || repo.ExisteDNIoEmail(persona.Email)) throw new DuplicadoException("Esa persona ya existe.");
        repo.DarAlta(persona);
    }
}