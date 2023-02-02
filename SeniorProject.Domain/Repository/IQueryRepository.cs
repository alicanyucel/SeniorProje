using SeniorProject.Domain.Primitives;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace SeniorProject.Domain.Repository
{
    public interface IQueryRepository<T>:IRepository<T> where T:Entity
    {
        IQueryable<T> GetAll();
        IQueryable<T> GetWhere(Expression<Func<T, bool>> expression);
        Task<T> GetFirstByExpression(Expression<Func<T, bool>> expression);
        Task<T> GetFirstById(string id);
    }
}
