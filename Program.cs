using api_admision.Infraestructure.Data;
using api_admision.Infraestructure.Shared.Exceptions;
using api_calidad.Application.UseCaseImpl;
using api_calidad.Domain.Repository;
using api_calidad.Domain.UseCase;
using api_calidad.Infraestructure.RepositoryImpl;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAll",
        policy => policy.AllowAnyOrigin()
                        .AllowAnyMethod()
                        .AllowAnyHeader());
});

// Add services to the container.
builder.Services.AddDbContextPool<ApplicationDbContext>(opciones => opciones.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddControllers();

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<ICalidadUseCase, CalidadUseCase>();
builder.Services.AddScoped<ICalidadRepository, CalidadRepositoryImpl>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseRouting();

app.UseCors("AllowAll");

app.UseMiddleware<ExceptionMiddleware>();

app.UseSwagger();
app.UseSwaggerUI(c =>
{
    c.SwaggerEndpoint("/swagger/v1/swagger.json", "Servicio API v1");
    c.DocumentTitle = "Servicio Calidad API Docs";
});



app.UseAuthorization();

app.MapControllers();

app.Run();
