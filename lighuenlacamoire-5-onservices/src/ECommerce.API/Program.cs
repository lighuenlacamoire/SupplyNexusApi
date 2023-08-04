using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Configuration;
using ECommerce.Services.Support;
using ECommerce.Infrastructure.Support;
using ECommerce.Infrastructure.ORM;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddCCDatabase();
builder.Services.AddCCServices();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCCDatabase();
/*
using (var scope =
  app.Services.CreateScope())
using (var context = scope.ServiceProvider.GetRequiredService<DataContext>())
    context.Database.EnsureCreated();
*/

app.UseAuthorization();

app.MapControllers();

app.Run();
