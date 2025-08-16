namespace CentroEventos.Aplicacion;

public interface IRepositorioPersona
{
    void DarAlta(Persona persona);
    void DarBaja(int Id);
    void Modificar(Persona persona);
    bool ExisteId(int id);
    bool ExisteDNIoEmail(string s);
    List<Persona> Listar();
    Persona DevolverPersona(int id);
    Persona DevolverPersona(string s);
}