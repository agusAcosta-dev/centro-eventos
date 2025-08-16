namespace CentroEventos.Aplicacion.UseCases.UsuarioUseCases;

public class UsuarioDevolverUseCase(IRepositorioUsuario repo)
{
    public Clases.Usuario Ejecutar(int id)
    {
        if (!repo.ExisteId(id)) throw new EntidadNotFoundException("Usuario inexistente.");
        return repo.DevolverUsuario(id);
    }
    public Clases.Usuario Ejecutar(string id)
    {
        if (!repo.ExisteEmail(id)) throw new EntidadNotFoundException("Usuario inexistente.");
        return repo.DevolverUsuario(id);
    }
}
