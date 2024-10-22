using Prometheus; // Aseg�rate de agregar esta l�nea

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

// Agregar el middleware de Prometheus para exponer m�tricas
app.UseRouting(); // Necesario para el enrutamiento de Prometheus
app.UseHttpMetrics(); // Middleware para recopilar m�tricas HTTP
app.UseEndpoints(endpoints =>
{
    // Exponer m�tricas en la ruta /metrics
    endpoints.MapMetrics();
});

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();

app.Run();
