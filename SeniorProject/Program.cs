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
using AssemblyReference = SeniorProject.Persistance.AssemblyReference;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<AppDbContext>(b => b.UseSqlServer(builder.Configuration.GetConnectionString("SqlServer")));
builder.Services.AddTransient<IProductCommandRepository, ProductCommandRepository>();
builder.Services.AddTransient<IProductQueryRepository, ProductQueryRepository>();
builder.Services.AddTransient<ICompanyCommandRepository, CompanyCommandRepository>();
builder.Services.AddTransient<ICompanyQueryRepository, CompanyQueryRepository>();
builder.Services.AddTransient<IOrderCommandRepository, OrderCommandRepository>();
builder.Services.AddTransient<IOrderQueryRepository, OrderQueryRepository>();
builder.Services.AddTransient<IProductService, ProductService>();
builder.Services.AddTransient<ICompanyService, CompanyService>();
builder.Services.AddTransient<IOrderService, OrderService>();
builder.Services.AddTransient<IUnitOfWork, UnitOfWork>();
builder.Services.AddMediatR(typeof(SeniorProject.Application.AssemblyReference).Assembly);
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
