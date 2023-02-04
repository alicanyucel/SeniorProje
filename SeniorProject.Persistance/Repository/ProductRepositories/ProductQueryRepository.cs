using Microsoft.EntityFrameworkCore;
using SeniorProject.Domain.Entities;
using SeniorProject.Domain.Repository.ProductRepositories;
using SeniorProject.Persistance.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeniorProject.Persistance.Repository.ProductRepositories
{
    public sealed class ProductQueryRepository : QueryRepository<Product>, IProductQueryRepository
    {
        public ProductQueryRepository(AppDbContext context): base(context)
        {
        }
    }
}
