using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeniorProject.Application.Features.Companies.Commands.CreateCompany
{
  public sealed record class CreateCompanyCommand(string CompanyName,int OrderStartTimeMinute,int OrderStartTimeHour,int  OrderFinishTimeHour,int OrderFinisTimeMinute):IRequest<CreateCompanyCommandResponse>;
   
}
