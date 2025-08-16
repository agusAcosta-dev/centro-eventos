using CentroEventos.Aplicacion;
using CentroEventos.Aplicacion.UseCases.Evento;
using CentroEventos.Consola.Components;
using CentroEventos.Repositorios;
using Microsoft.EntityFrameworkCore;
using CentroEventos.Aplicacion.Clases;
using CentroEventos.Aplicacion.UseCases.Reserva.UseCases;
using CentroEventos.Aplicacion.UseCases.PersonaUseCases;
using CentroEventos.Aplicacion.UseCases.EventoUseCases;
using CentroEventos.Aplicacion.UseCases.ReservaUseCases;
using CentroEventos.Aplicacion.UseCases.UsuarioUseCases;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

builder.Services.AddDbContext<CentroEventosContext>(options => options.UseSqlite("Data source=centroeventos.db"));

builder.Services.AddTransient<PersonaAltaUseCase>();
builder.Services.AddTransient<EventoAltaUseCase>();
builder.Services.AddTransient<ReservaAltaUseCase>();
builder.Services.AddTransient<PersonaBajaUseCase>();
builder.Services.AddTransient<EventoBajaUseCase>();
builder.Services.AddTransient<ReservaBajaUseCase>();
builder.Services.AddTransient<PersonaModificarUseCase>();
builder.Services.AddTransient<EventoModificarUseCase>();
builder.Services.AddTransient<ReservaModificarUseCase>();
builder.Services.AddTransient<ListarPersonaUseCase>();
builder.Services.AddTransient<ListarEventoDeportivoUseCase>();
builder.Services.AddTransient<ListarReservaUseCase>();
builder.Services.AddTransient<ListarEventosConCupoDisponibleUseCase>();
builder.Services.AddScoped<IRepositorioPersona, RepositorioPersona>();
builder.Services.AddScoped<IRepositorioEventoDeportivo, RepositorioEventoDeportivo>();
builder.Services.AddScoped<IRepositorioReserva, RepositorioReserva>();
builder.Services.AddTransient<PersonaValidador>();
builder.Services.AddTransient<EventoValidador>();
builder.Services.AddTransient<IServicioAutorizacion, ServicioAutorizacion>();
builder.Services.AddScoped<UsuarioActual>();
builder.Services.AddTransient<PersonaDevolverUseCase>();
builder.Services.AddTransient<EventoDevolverUseCase>();
builder.Services.AddTransient<ReservaDevolverUseCase>();
builder.Services.AddTransient<Hasher>();
builder.Services.AddTransient<ServicioAutorizacion>();
builder.Services.AddTransient<UsuarioAltaUseCase>();
builder.Services.AddTransient<UsuarioBajaUseCase>();
builder.Services.AddTransient<UsuarioValidador>();
builder.Services.AddTransient<UsuarioModificarUseCase>();
builder.Services.AddTransient<UsuarioDevolverUseCase>();
builder.Services.AddTransient<ListarUsuariosUseCase>();
builder.Services.AddTransient<ListarReservaAsistenciasUseCase>();
builder.Services.AddTransient<IRepositorioUsuario, RepositorioUsuario>();

var app = builder.Build();
using (var scope = app.Services.CreateScope())
{
    var db = scope.ServiceProvider.GetRequiredService<CentroEventosContext>();
    db.Database.EnsureCreated();
}
CentroEventosContext context = new CentroEventosContext();
var connection = context.Database.GetDbConnection();
connection.Open();
using (var command = connection.CreateCommand())
{
    command.CommandText = "PRAGMA journal_mode=DELETE;";
    command.ExecuteNonQuery();
}

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
}

app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();
