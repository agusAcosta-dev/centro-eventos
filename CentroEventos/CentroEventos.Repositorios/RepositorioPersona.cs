namespace CentroEventos.Repositorios;

using CentroEventos.Aplicacion;

public class RepositorioPersona : IRepositorioPersona
{
    public void DarAlta(Persona persona)
    {
        using var context = new CentroEventosContext();
        context.Add(persona);
        context.SaveChanges();
    }
    public void DarBaja(int Id)
    {
        using var context = new CentroEventosContext();
        Persona persona = context.Persona.Find(Id)!;
        context.Remove(persona);
        context.SaveChanges();
    }
    public void Modificar(Persona persona)
    {
        var context = new CentroEventosContext();
        Persona personaModificada = context.Persona.Find(persona.Id)!;
        personaModificada.Nombre = persona.Nombre;
        personaModificada.Apellido = persona.Apellido;
        personaModificada.Email = persona.Email;
        personaModificada.DNI = persona.DNI;
        personaModificada.Telefono = persona.Telefono;
        context.SaveChanges();
    }
    public List<Persona> Listar()
    {
        using var context = new CentroEventosContext();
        return context.Persona.ToList();
    }
    public bool ExisteId(int id)
    {
        using var context = new CentroEventosContext();
        return context.Persona.Any(p => p.Id == id);
    }
    public bool ExisteDNIoEmail(string s)
    {
        using var context = new CentroEventosContext();
        return context.Persona.Any(p => p.DNI == s || p.Email == s);
    }
    public Persona DevolverPersona(int id)
    {
        using var context = new CentroEventosContext();
        return context.Persona.Find(id)!;
    }
    public Persona DevolverPersona(string dni)
    {
        using var context = new CentroEventosContext();
        return context.Persona.FirstOrDefault(p => p.DNI == dni)!;
    }
}