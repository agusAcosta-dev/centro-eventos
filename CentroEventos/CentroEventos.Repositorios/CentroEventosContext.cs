using Microsoft.EntityFrameworkCore;
using CentroEventos.Aplicacion.Clases;
using CentroEventos.Aplicacion;
namespace CentroEventos.Repositorios;

public class CentroEventosContext : DbContext
{
    public DbSet<Persona> Persona { get; set; }
    public DbSet<EventoDeportivo> Evento { get; set; }
    public DbSet<Reserva> Reserva { get; set; }
    public DbSet<Usuario> Usuario { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("data source=CentroEventos.sqlite");
    }
    public CentroEventosContext() { }
    public CentroEventosContext(DbContextOptions<CentroEventosContext> options)
            : base(options)
    {
    }
}

