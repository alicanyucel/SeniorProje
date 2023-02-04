using SeniorProject.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeniorProject.Application.Features.Companies.Queries.GetAllCompanyQuery
{
 public sealed record GetAllCompanyQueryResponse(
     IQueryable<Company>Companies);
   
}
