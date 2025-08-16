namespace CentroEventos.Aplicacion;

[Flags]
public enum Permiso
{
    EventoAlta = 1,
    EventoModificacion = 2,
    EventoBaja = 4,
    ReservaAlta = 8,
    ReservaModificacion = 16,
    ReservaBaja = 32,
    UsuarioBaja = 64,
    UsuarioModificacion = 128,
    PersonaAlta = 256,
    PersonaBaja = 512,
    PersonaModificacion = 1024
}