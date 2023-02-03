using SeniorProject.Domain.Entities;
using SeniorProject.Domain.Repository.CompanyRepository;
using SeniorProject.Persistance.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeniorProject.Persistance.Repository.CompanyRepositories
{
    public sealed class CompanyCommandRepository : CommandRepository<Company>, ICompanyCommandRepository
    {
        public CompanyCommandRepository(AppDbContext context) : base(context)
        {
        }
    }
}
