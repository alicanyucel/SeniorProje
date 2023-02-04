using MediatR;
using Microsoft.AspNetCore.Mvc;
using SeniorProject.Application.Features.Orders.CreateOrderCommands;
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
    public class OrderController : ApiController

    {
        public OrderController(IMediator mediator) : base(mediator)
        {
        }
        [HttpPost("[action]")]
        public async Task<IActionResult> CreateOrder(CreateOrderCommand request)
        {
            CreateOrderCommandResponse response = await _mediator.Send(request);
            return Ok(response);
        }
    }
}
