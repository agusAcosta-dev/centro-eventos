namespace CentroEventos.Aplicacion.UseCases.PersonaUseCases;
using CentroEventos.Aplicacion;

public class PersonaModificarUseCase(IRepositorioPersona repo, IServicioAutorizacion autorizacion)
{
    public void Ejecutar(Persona persona, int id)
    {
        if (!autorizacion.PoseeElPermiso(id, Permiso.PersonaModificacion)) throw new FalloAutorizacionException();
        repo.Modificar(persona);
    }
}