using Microsoft.EntityFrameworkCore;
using SeniorProject.Persistance.Context;
using SeniorProject.Presentation;
var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<AppDbContext>(b => b.UseSqlServer(builder.Configuration.GetConnectionString("SqlServer")));
// Add services to the container.

builder.Services.AddControllers().AddApplicationPart(typeof(AssemblyReference).Assembly);
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

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

app.Run();
