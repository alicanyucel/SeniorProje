using Microsoft.AspNetCore.Mvc;
using SeniorProject.Presentation.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeniorProject.Presentation.Controller
{
   public class CompanyController:ApiController
    {
        [HttpGet]
        public IActionResult Get()
        {
            return NoContent();
        }
    }
}
