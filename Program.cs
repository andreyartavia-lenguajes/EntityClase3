using EntityFrameworkClase2.Data;
using EntityFrameworkClase2.Models;
using EntityFrameworkClase2.Services;
using Microsoft.EntityFrameworkCore;
using System;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// DB Context
builder.Services.AddDbContext<UsuarioDBContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DBClase2")));

// DI
builder.Services.AddScoped<IUsuarioRepository, UsuarioRepository>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(c =>
    {
        c.SwaggerEndpoint("/swagger/v1/swagger.json", "EdemploClase2 API V1");
        c.RoutePrefix = string.Empty; // Set Swagger UI at the app's root
        c.DocumentTitle = "EjemploClase2 API Documentation";
    });
}

app.UseAuthorization();

app.MapControllers();

app.Run();