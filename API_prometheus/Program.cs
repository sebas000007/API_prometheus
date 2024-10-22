using Prometheus; // Asegúrate de agregar esta línea

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

// Agregar el middleware de Prometheus para exponer métricas
app.UseRouting(); // Necesario para el enrutamiento de Prometheus
app.UseHttpMetrics(); // Middleware para recopilar métricas HTTP
app.UseEndpoints(endpoints =>
{
    // Exponer métricas en la ruta /metrics
    endpoints.MapMetrics();
});

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();

app.Run();
