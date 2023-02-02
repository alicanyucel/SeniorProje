using Microsoft.EntityFrameworkCore;
using SeniorProject.Domain.Primitives;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeniorProject.Domain.Repository
{
    public interface IRepository<T> where T:Entity
    {
        DbSet<T> Entity { get; set; }

    }
}
