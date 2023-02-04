using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeniorProject.Application.Features.Orders.CreateOrderCommands
{
  public sealed record CreateOrderCommandResponse(
      string Message="siparis olusturuldu");
   
}
