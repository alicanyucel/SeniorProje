﻿using MediatR;
using SeniorProject.Application.Services;
using SeniorProject.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeniorProject.Application.Features.Orders.CreateOrderCommands
{
    public sealed class CreateOrderCommandHandler : IRequestHandler<CreateOrderCommand, CreateOrderCommandResponse>
    {
        private readonly IOrderService _orderService;
        private readonly ICompanyService _companyService;

        public CreateOrderCommandHandler(IOrderService orderService, ICompanyService companyService)
        {
            _orderService = orderService;
            _companyService = companyService;
        }

        public async Task<CreateOrderCommandResponse> Handle(CreateOrderCommand request, CancellationToken cancellationToken)
        {
           
            Company company = await _companyService.GetCompanyById(request.FirmaId);
            if (!company.ApprovalStatus) throw new Exception("Şirket aktif olmadığından sipariş alamıyor!");

            int orderStartHour = company.OrderStartTime.Hours;
            int orderStartMin = company.OrderStartTime.Minutes;

            int orderFinishHour = company.OrderFinishTime.Hours;
            int orderFinishMin = company.OrderFinishTime.Minutes;

            int nowHour = DateTime.Now.Hour;
            int nowMin = DateTime.Now.Minute;

            if (orderStartHour < nowHour)
            {
                if (orderFinishHour >= nowHour && orderFinishMin >= nowMin)
                {
                    await _orderService.CreateOrder(request);
                }

            }
            else if (orderStartHour == nowHour)
            {
                if (orderStartMin > nowMin)
                {
                    await _orderService.CreateOrder(request);
                }
            }
            else
            {
                throw new Exception("Siparişiniz firmanın sipariş aldığı aralık dışında!");
            }

            return new();
        }
    }
}
