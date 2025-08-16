namespace CentroEventos.Aplicacion.UseCases.PersonaUseCases;

using CentroEventos.Aplicacion;
public class UsuarioBajaUseCase(IRepositorioUsuario repo, IServicioAutorizacion autorizacion)
{
    public void Ejecutar(int idEliminar, int id)
    {
        if (!autorizacion.PoseeElPermiso(id, Permiso.UsuarioBaja)) throw new FalloAutorizacionException();
        repo.DarBaja(idEliminar);
    }
}