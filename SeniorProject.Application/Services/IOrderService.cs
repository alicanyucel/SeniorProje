using SeniorProject.Application.Features.Orders.CreateOrderCommands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeniorProject.Application.Services
{
    public interface IOrderService
    {
        Task CreateOrder(CreateOrderCommand request);
    }
}
