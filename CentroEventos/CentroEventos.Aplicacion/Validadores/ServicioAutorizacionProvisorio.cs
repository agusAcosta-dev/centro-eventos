using CentroEventos.Aplicacion.Clases;

namespace CentroEventos.Aplicacion;

public class ServicioAutorizacion(IRepositorioUsuario repo) : IServicioAutorizacion
{
    public bool PoseeElPermiso(int IdUsuario, Permiso permiso)
    {
        if (IdUsuario == 1 || IdUsuario == 0) return true;
        Usuario usuario = repo.DevolverUsuario(IdUsuario);
        if (usuario == null) return false;
        return (usuario.Permisos & permiso) == permiso;
    }
}