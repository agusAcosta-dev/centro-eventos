namespace CentroEventos.Aplicacion.UseCases.PersonaUseCases;

using CentroEventos.Aplicacion;
using CentroEventos.Aplicacion.Clases;

public class ListarUsuariosUseCase(IRepositorioUsuario repo)
{
    public List<Usuario> Ejecutar()
    {
        return repo.Listar();
    }
}