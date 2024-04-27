using System.Configuration;
using Microsoft.EntityFrameworkCore;
using WebApplication2.Db;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<CspsDbContext>(options => 
    options.UseOracle(builder.Configuration.GetConnectionString("CSPS")));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.MapGet("", (CspsDbContext context) =>
{
    return context.Corporates.ToArray();
});

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
