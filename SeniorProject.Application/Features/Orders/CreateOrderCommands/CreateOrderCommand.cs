using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeniorProject.Application.Features.Orders.CreateOrderCommands
{
   public sealed record CreateOrderCommand(string FirmaId,string CustomerName,string ProductId):IRequest<CreateOrderCommandResponse>;
  
}
