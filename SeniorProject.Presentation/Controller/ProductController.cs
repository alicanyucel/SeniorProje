using MediatR;
using Microsoft.AspNetCore.Mvc;
using SeniorProject.Application.Features.Products.Commands.CreateProduct;
using SeniorProject.Presentation.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeniorProject.Presentation.Controller
{
    [ApiController]
    [Route("api/[controller]")]
 public  sealed class ProductController:ApiController
    {
        public readonly IMediator _mediatr;
        public ProductController(IMediator mediator)
        {
            _mediatr= mediator;
        }
        [HttpPost("[action]")]
        public async Task<IActionResult> CreateProduct(CreateProductCommand request)
        {
            CreateProductCommandResponse response = await _mediatr.Send(request);
            return Ok(response);
        }


    }       
}
