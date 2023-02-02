using SeniorProject.Domain.Primitives;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeniorProject.Domain.Repository
{
    public interface ICommandRepository<T> where T:Entity 
    {
        void Remove(T entity);
        Task AddAsync(T entity);
        void Update(T entity);
        Task RemoveByIdAsync(string id);


    }
}
