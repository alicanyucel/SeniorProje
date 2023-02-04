using SeniorProject.Application.Features.Companies.Commands.CreateCompany;
using SeniorProject.Application.Features.Companies.Commands.UpdateCompany;
using SeniorProject.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeniorProject.Application.Services
{
  public interface ICompanyService
    {
        Task CreateCompanyAsync(CreateCompanyCommand request);
        Task UpdateCompanyAsync(UpdateCompanyCommand request);
        IQueryable<Company> GetAll();
        Task<Company> GetCompanyById(string CompanyId);

    }
}
