namespace CentroEventos.Aplicacion.UseCases.PersonaUseCases;

using CentroEventos.Aplicacion;
public class PersonaBajaUseCase(IRepositorioPersona repoPersona, IRepositorioEventoDeportivo repoEvento, IRepositorioReserva repoReserva, IServicioAutorizacion autorizacion)
{
    public void Ejecutar(int idEliminar, int id)
    {
        if (!autorizacion.PoseeElPermiso(id, Permiso.PersonaBaja)) throw new FalloAutorizacionException();
        if (repoEvento.EsResponsable(idEliminar) || repoReserva.ExisteReserva(idEliminar)) throw new OperacionInvalidaException();
        repoPersona.DarBaja(idEliminar);
    }
}