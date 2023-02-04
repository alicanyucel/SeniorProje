using SeniorProject.Application.Features.Products.Commands.CreateProduct;
using SeniorProject.Application.Services;
using SeniorProject.Domain;
using SeniorProject.Domain.Entities;
using SeniorProject.Domain.Repository.ProductRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace SeniorProject.Persistance.Service
{
    public sealed class ProductService : IProductService
    {
        private readonly IProductCommandRepository _commandRepository;
        private readonly IUnitOfWork _unitOfWork;
        public ProductService(IProductCommandRepository commandRepository, IUnitOfWork unitOfWork)
        {
            _commandRepository = commandRepository;
            _unitOfWork = unitOfWork;
        }

        public async Task AddAsync(CreateProductCommand request)
        {
            Product product = new Product
            {
                Id = Guid.NewGuid().ToString(),
                CompanyId = request.CompanyId,
                CreateDate = DateTime.Now,
                ProductName = request.ProductName,
                Stock = request.Stock,
                Price = request.Price,

            };
            
            await _commandRepository.AddAsync(product);
            await _unitOfWork.SaveChangesAsync();

        }
    }
}
