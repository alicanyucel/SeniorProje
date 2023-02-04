using SeniorProject.Application.Features.Orders.CreateOrderCommands;
using SeniorProject.Application.Services;
using SeniorProject.Domain;
using SeniorProject.Domain.Entities;
using SeniorProject.Domain.Repository.OrderRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeniorProject.Persistance.Service
{
    public sealed class OrderService : IOrderService
    {
        private IOrderCommandRepository _commandRepository;
        private IUnitOfWork _unitofwork;

        public OrderService(IOrderCommandRepository commandRepository, IUnitOfWork unitofwork)
        {
            _commandRepository = commandRepository;
            _unitofwork = unitofwork;
        }

        public async Task CreateOrder(CreateOrderCommand request)
        {
            Order order = new()
            {
                Id = Guid.NewGuid().ToString(),
                CreateDate = DateTime.Now,
                CustomerName = request.CustomerName,
                FirmaId = request.FirmaId,
                OrderDate = DateTime.Now,
                ProductId = request.ProductId,
            };
            await _commandRepository.AddAsync(order);
            await _unitofwork.SaveChangesAsync();
        }
    }
}
