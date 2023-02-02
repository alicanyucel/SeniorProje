using SeniorProject.Domain.Primitives;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeniorProject.Domain.Entities
{
    public sealed class Company : Entity
    {// gün içerisinde bitecek
        public string CompanyName { get; set; }
        public bool ApprovalStatus { get; set; }
        public int OrderStartTimeHour { get; set; }
        public int OrderStartTimeMinute { get; set; }
        public int OrderFinishTimeHour { get; set; }
        public int OrderFinishTimeMinute { get; set; }
        public ICollection<Product> Products { get; set; }


    }
}
