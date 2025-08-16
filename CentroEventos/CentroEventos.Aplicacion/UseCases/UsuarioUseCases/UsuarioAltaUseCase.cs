namespace CentroEventos.Aplicacion.UseCases.UsuarioUseCases;

using CentroEventos.Aplicacion;
using CentroEventos.Aplicacion.Clases;

public class UsuarioAltaUseCase(IRepositorioUsuario repo, UsuarioValidador validador)
{
    public void Ejecutar(Usuario usuario)
    {
        if (!validador.Validar(usuario)) throw new ValidacionException("Usuario no válido.");
        if (repo.ExisteEmail(usuario.Email)) throw new DuplicadoException("Esa persona ya existe.");
        repo.DarAlta(usuario);
    }
}