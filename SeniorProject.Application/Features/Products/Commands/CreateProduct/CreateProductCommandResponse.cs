using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeniorProject.Application.Features.Products.Commands.CreateProduct
{
    public sealed record CreateProductCommandResponse(
        string Message="the products added");
    
}
