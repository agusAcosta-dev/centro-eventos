namespace CentroEventos.Aplicacion.UseCases.PersonaUseCases;
using CentroEventos.Aplicacion;
using CentroEventos.Aplicacion.Clases;

public class UsuarioModificarUseCase(IRepositorioUsuario repo, IServicioAutorizacion autorizacion)
{
    public void Ejecutar(Usuario usuario, int id)
    {
        if (!autorizacion.PoseeElPermiso(id, Permiso.UsuarioModificacion) && (usuario.Id != id)) throw new FalloAutorizacionException();
        if (repo.DevolverUsuario(usuario.Id) == null) throw new EntidadNotFoundException("No existe ese usuario.");
        repo.Modificar(usuario);
    }
}