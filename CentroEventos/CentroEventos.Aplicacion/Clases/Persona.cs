
namespace CentroEventos.Aplicacion;

public class Persona
{
    public int Id { get; private set; }
    public string DNI { set; get; } = "";
    public string Nombre { set; get; } = "";
    public string Apellido { set; get; } = "";
    public string Email { set; get; } = "";
    public string Telefono { set; get; } = "";
    public Persona() { }
    public Persona(Persona persona)
    {
        Id = persona.Id;
        DNI = persona.DNI;
        Nombre = persona.Nombre;
        Apellido = persona.Apellido;
        Email = persona.Email;
        Telefono = persona.Telefono;
    }
    public Persona(string nombre, string apellido, string dni, string email, string telefono)
    {
        Nombre = nombre;
        Apellido = apellido;
        DNI = dni;
        Email = email;
        Telefono = telefono;
    }
    public override string ToString()
    {
        return $"Nombre: {Apellido} {Nombre} - DNI: {DNI} \nID: {Id} - Email: {Email} - Telefono: {Telefono}";
    }
}