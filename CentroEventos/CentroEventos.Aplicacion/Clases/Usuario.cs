namespace CentroEventos.Aplicacion.Clases;

public class Usuario
{
    public int Id { set; get; }
    public string Nombre { set; get; } = "";
    public string Apellido { set; get; } = "";
    public string Email { set; get; } = "";
    public string Contrasena { set; get; } = "";
    public Permiso Permisos { set; get; }

    public void SetPermisos(Permiso permiso)
    {
        Permisos = permiso;
    }
}
