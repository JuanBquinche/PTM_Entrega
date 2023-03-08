using Microsoft.EntityFrameworkCore;
using PTMicroservicios.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddDbContext<AppDbContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("SqlServerConn"));
});

builder.Services.AddScoped<IPersonaRepo, PersonaRepo>();
builder.Services.AddScoped<IClienteRepo, ClienteRepo>();
builder.Services.AddScoped<ICuentaRepo, CuentaRepo>();
builder.Services.AddScoped<IMovimientoRepo, MovimientoRepo>();

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();
//PrepDb.PreparaData(app);
app.Run();
