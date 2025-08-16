public class EntidadNotFoundException : Exception
{
    public EntidadNotFoundException(int id) : base($"No existe el ID {id}.") { }
    public EntidadNotFoundException(string mensaje) : base(mensaje) { }
    public EntidadNotFoundException() : base("Entidad no válida.") { }
}