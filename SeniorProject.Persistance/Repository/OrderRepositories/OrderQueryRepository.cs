using Microsoft.EntityFrameworkCore;
using SeniorProject.Domain.Entities;
using SeniorProject.Domain.Repository;
using SeniorProject.Domain.Repository.OrderRepositories;
using SeniorProject.Persistance.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeniorProject.Persistance.Repository.OrderRepositories
{
    public sealed class OrderQueryRepository : QueryRepository<Order>, IOrderQueryRepository
    {
        public OrderQueryRepository(AppDbContext context) : base(context)
        {
        }
    }
}
