using MediatR;
using Microsoft.EntityFrameworkCore;
using SeniorProject.Application.Services;
using SeniorProject.Domain.Repository.CompanyRepositories;
using SeniorProject.Domain.Repository.CompanyRepository;
using SeniorProject.Domain.Repository.OrderRepositories;
using SeniorProject.Domain.Repository.ProductRepositories;
using SeniorProject.Domain.Repository.ProductRepository;
using SeniorProject.Domain;
using SeniorProject.Persistance;
using SeniorProject.Persistance.Context;
using SeniorProject.Persistance.Repository.CompanyRepositories;
using SeniorProject.Persistance.Repository.OrderRepositories;
using SeniorProject.Persistance.Repository.ProductRepositories;
using SeniorProject.Persistance.Service;
using SeniorProject.Presentation;
var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<AppDbContext>(b => b.UseSqlServer(builder.Configuration.GetConnectionString("SqlServer")));
// Add services to the container.
// dependency Injection
// Add services to the container.
#region Dependency Injection
builder.Services.AddSingleton<IProductCommandRepository, ProductCommandRepository>();
builder.Services.AddSingleton<IProductQueryRepository, ProductQueryRepository>();
builder.Services.AddSingleton<ICompanyCommandRepository, CompanyCommandRepository>();
builder.Services.AddSingleton<ICompanyQueryRepository, CompanyQueryRepository>();
builder.Services.AddSingleton<IOrderCommandRepository, OrderCommandRepository>();
builder.Services.AddSingleton<IOrderQueryRepository, OrderQueryRepository>();

builder.Services.AddSingleton<IProductService, ProductService>();
builder.Services.AddSingleton<ICompanyService, CompanyService>();
builder.Services.AddSingleton<IOrderService, OrderService>();

builder.Services.AddSingleton<IUnitOfWork, UnitOfWork>();
#endregion

builder.Services.AddMediatR(typeof(SeniorProject.Application.AssemblyReference).Assembly);

builder.Services.AddControllers().AddApplicationPart(typeof(SeniorProject.Presentation.AssemblyReference).Assembly);

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
app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

app.Run();
