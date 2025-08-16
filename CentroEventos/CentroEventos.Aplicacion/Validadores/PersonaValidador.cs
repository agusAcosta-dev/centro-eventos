namespace CentroEventos.Aplicacion;

public class PersonaValidador
{
    public bool Validar(Persona persona)
    {
        if (string.IsNullOrWhiteSpace(persona.Nombre)
            || string.IsNullOrWhiteSpace(persona.DNI)
            || string.IsNullOrWhiteSpace(persona.Apellido)
            || string.IsNullOrWhiteSpace(persona.Email)) return false;
        return true;
    }
}