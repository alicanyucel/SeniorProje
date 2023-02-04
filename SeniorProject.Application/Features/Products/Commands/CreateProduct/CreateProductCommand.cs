using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeniorProject.Application.Features.Products.Commands.CreateProduct
{
    public sealed record class CreateProductCommand(string ProductName, decimal Price, decimal Stock, string CompanyId) : IRequest<CreateProductCommandResponse>;
   
}