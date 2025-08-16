namespace CentroEventos.Repositorios;

using CentroEventos.Aplicacion;
using CentroEventos.Aplicacion.Clases;

public class RepositorioUsuario : IRepositorioUsuario
{
    public void DarAlta(Usuario usuario)
    {
        using var context = new CentroEventosContext();
        context.Add(usuario);
        context.SaveChanges();
    }
    public void DarBaja(int Id)
    {
        using var context = new CentroEventosContext();
        Usuario usuario = context.Usuario.Find(Id)!;
        context.Remove(usuario);
        context.SaveChanges();
    }
    public void Modificar(Usuario usuario)
    {
        var context = new CentroEventosContext();
        Usuario usuarioModificado = context.Usuario.Find(usuario.Id)!;
        usuarioModificado.Nombre = usuario.Nombre;
        usuarioModificado.Apellido = usuario.Apellido;
        usuarioModificado.Email = usuario.Email;
        usuarioModificado.Contrasena = usuario.Contrasena;
        usuarioModificado.Permisos = usuario.Permisos;
        context.SaveChanges();
    }
    public List<Usuario> Listar()
    {
        using var context = new CentroEventosContext();
        return context.Usuario.ToList();
    }
    public bool ExisteId(int id)
    {
        using var context = new CentroEventosContext();
        return context.Usuario.Any(u => u.Id == id);
    }
    public bool ExisteEmail(string e)
    {
        using var context = new CentroEventosContext();
        return context.Usuario.Any(u => u.Email == e);
    }
    public Usuario DevolverUsuario(int id)
    {
        using var context = new CentroEventosContext();
        return context.Usuario.Find(id)!;
    }
    public Usuario DevolverUsuario(string email)
    {
        using var context = new CentroEventosContext();
        return context.Usuario.FirstOrDefault(u => u.Email == email)!;
    }
}