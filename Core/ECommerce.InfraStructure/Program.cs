using ECommerce.InfraStructure.Configuration;
using ECommerce.InfraStructure.Contexts;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext();

builder.Services.AddRepositories();

builder.Services.AddSwaggerOpenAPI();

var app = builder.Build();

app.MapControllers();

app.UseSwagger();

app.UseSwaggerConfig();

app.Run();