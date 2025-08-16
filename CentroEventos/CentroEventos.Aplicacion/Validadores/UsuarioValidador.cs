using CentroEventos.Aplicacion.Clases;

namespace CentroEventos.Aplicacion;

public class UsuarioValidador
{
    public bool Validar(Usuario usuario)
    {
        if (string.IsNullOrWhiteSpace(usuario.Nombre)
            || string.IsNullOrWhiteSpace(usuario.Apellido)
            || string.IsNullOrWhiteSpace(usuario.Email)
            || string.IsNullOrWhiteSpace(usuario.Contrasena)) return false;
        if (!usuario.Email.Contains('@') || (!usuario.Email.Contains('.'))) return false;
        return true;
    }
}