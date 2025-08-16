using CentroEventos.Aplicacion.Clases;

namespace CentroEventos.Aplicacion;

public interface IRepositorioUsuario
{
    void DarAlta(Usuario usuario);
    void DarBaja(int Id);
    void Modificar(Usuario usuario);
    bool ExisteId(int id);
    bool ExisteEmail(string email);
    List<Usuario> Listar();
    Usuario DevolverUsuario(int id);
    Usuario DevolverUsuario(string email);
}