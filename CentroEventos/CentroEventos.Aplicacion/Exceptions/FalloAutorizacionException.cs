namespace CentroEventos.Aplicacion;
public class FalloAutorizacionException : Exception {
    public FalloAutorizacionException() : base("Permisos insuficientes.") { }
}