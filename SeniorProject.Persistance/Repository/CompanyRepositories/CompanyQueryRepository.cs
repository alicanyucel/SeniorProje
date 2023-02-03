using Microsoft.EntityFrameworkCore;
using SeniorProject.Domain.Entities;
using SeniorProject.Domain.Repository.CompanyRepositories;
using SeniorProject.Persistance.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeniorProject.Persistance.Repository.CompanyRepositories
{
    public sealed class CompanyQueryRepository : QueryRepository<Company>, ICompanyQueryRepository
    {
        public CompanyQueryRepository(AppDbContext context, DbSet<Company> entity) : base(context, entity)
        {
        }
    }
}
