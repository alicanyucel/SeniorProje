using SeniorProject.Domain.Entities;
using SeniorProject.Domain.Repository.OrderRepositories;
using SeniorProject.Persistance.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeniorProject.Persistance.Repository.OrderRepositories
{
    public sealed class OrderCommandRepository : CommandRepository<Order>, IOrderCommandRepository
    {
        public OrderCommandRepository(AppDbContext context) : base(context)
        {
        }
    }
}
