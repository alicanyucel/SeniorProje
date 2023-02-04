using MediatR;
using SeniorProject.Application.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeniorProject.Application.Features.Products.Commands.CreateProduct
{
    public sealed class CreateProductCommandHandler : IRequestHandler<CreateProductCommand, CreateProductCommandResponse>
    {
        public CreateProductCommandHandler(IProductService productService)
        {
            _productservice=productService;
        }
        private readonly IProductService _productservice;
        public async Task<CreateProductCommandResponse> Handle(CreateProductCommand request,CancellationToken cancellationToken)
        {
            await _productservice.AddAsync(request);
            return new();
        }
    }
}
