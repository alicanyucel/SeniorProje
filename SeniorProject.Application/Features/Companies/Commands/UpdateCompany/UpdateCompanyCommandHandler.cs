using MediatR;
using SeniorProject.Application.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeniorProject.Application.Features.Companies.Commands.UpdateCompany
{
    public sealed class UpdateCompanyCommandHandler : IRequestHandler<UpdateCompanyCommand, UpdateCompanyCommandResponse>
    {
        private readonly ICompanyService _companyService;

        public UpdateCompanyCommandHandler(ICompanyService companyService)
        {
            _companyService = companyService;
        }

        public async Task<UpdateCompanyCommandResponse> Handle(UpdateCompanyCommand request, CancellationToken cancellationToken)
        {
            await _companyService.UpdateCompanyAsync(request);
            return new();
        }
    }
}
