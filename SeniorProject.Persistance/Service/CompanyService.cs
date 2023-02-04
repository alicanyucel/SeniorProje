using SeniorProject.Application.Features.Companies.Commands.CreateCompany;
using SeniorProject.Application.Features.Companies.Commands.UpdateCompany;
using SeniorProject.Application.Services;
using SeniorProject.Domain;
using SeniorProject.Domain.Entities;
using SeniorProject.Domain.Repository.CompanyRepositories;
using SeniorProject.Domain.Repository.CompanyRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeniorProject.Persistance.Service
{
    public  class CompanyService : ICompanyService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ICompanyCommandRepository _companyCommandRepository;
        private readonly ICompanyQueryRepository _companyQueryRepository;
        

        public CompanyService(IUnitOfWork unitOfWork, ICompanyCommandRepository companyCommandRepository, ICompanyQueryRepository companyQueryRepository)
        {
            _unitOfWork = unitOfWork;
            _companyCommandRepository = companyCommandRepository;
            _companyQueryRepository = companyQueryRepository;
        }

        public async Task CreateCompanyAsync(CreateCompanyCommand request)
        {
            Company company = new()
            {
                Id = Guid.NewGuid().ToString(),
                ApprovalStatus = false,
                CompanyName = request.CompanyName,
                CreateDate = DateTime.Now,
                OrderStartTime = request.OrderStartTime,
                OrderFinishTime = request.OrderFinishTime
            };
            await _companyCommandRepository.AddAsync(company);
            await _unitOfWork.SaveChangesAsync();
        }

        public IQueryable<Company> GetAll()
        {
            return _companyQueryRepository.GetAll();
        }

        public async Task<Company> GetCompanyById(string CompanyId)
        {
            return await _companyQueryRepository.GetFirstById(CompanyId);
        }

        public async Task UpdateCompanyAsync(UpdateCompanyCommand request)
        {
            var company = await _companyQueryRepository.GetFirstById(request.CompanyId);
            if (company == null)
            {
                throw new Exception("şirket kaydı bulunamadi");
            }
            if(company.ApprovalStatus)
            {
                throw new Exception("şirket zaten onaylandı");
            }
            company.ApprovalStatus = true;
            company.OrderStartTime = request.OrderStartTime;
            _companyCommandRepository.Update(company);
            await _unitOfWork.SaveChangesAsync();




        }
    }
}
