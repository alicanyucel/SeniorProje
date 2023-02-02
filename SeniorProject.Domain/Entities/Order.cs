using Microsoft.EntityFrameworkCore.Metadata.Internal;
using SeniorProject.Domain.Primitives;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeniorProject.Domain.Entities
{
   public sealed class Order:Entity
    {
        public string CustomerName { get; set; }
        public DateTime OrderDate { get; set; }

        public string CompanyId { get; set; }
        public string ProductId { get; set; }
        public Product Product { get; set; }
    }
}
