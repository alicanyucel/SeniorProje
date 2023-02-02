using Microsoft.EntityFrameworkCore;
using SeniorProject.Domain.Primitives;
using SeniorProject.Domain.Repository;
using SeniorProject.Persistance.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace SeniorProject.Persistance.Repository
{
    public class QueryRepository<T> : IQueryRepository<T> where T:Entity
    {
        private readonly Func<AppDbContext, string,Task<T>> GetByCompiled = EF.CompileAsyncQuery((AppDbContext context, string id) => context.Set<T>().FirstOrDefault(p => p.Id == id));
        private readonly AppDbContext _context;
        public QueryRepository(AppDbContext context, DbSet<T> entity)
        {
            _context = context;
            Entity = context.Set<T>();
        }

        public DbSet<T> Entity { get; set; }
        public IQueryable<T> GetAll()
        {
            return Entity.AsQueryable();
        }

        public async Task<T> GetFirstByExpression(Expression<Func<T, bool>> expression)
        {
            return await Entity.FirstOrDefaultAsync(expression);
        }

        public async Task<T> GetFirstById(string id)
        {
            return await GetByCompiled(_context, id);
        }

        public IQueryable<T> GetWhere(Expression<Func<T, bool>> expression)
        {
            return Entity.Where(expression);
        }
    }
}
