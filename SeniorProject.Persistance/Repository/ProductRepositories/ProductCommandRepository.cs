using SeniorProject.Domain.Entities;
using SeniorProject.Domain.Repository.ProductRepository;
using SeniorProject.Persistance.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeniorProject.Persistance.Repository.ProductRepositories
{
    public sealed class ProductCommandRepository : CommandRepository<Product>,IProductCommandRepository
    {
        public ProductCommandRepository(AppDbContext context) : base(context)
        {
        }
    }
}
