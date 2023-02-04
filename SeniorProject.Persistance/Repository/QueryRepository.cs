﻿using Microsoft.EntityFrameworkCore;
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
    public class QueryRepository<T> : IQueryRepository<T>
     where T : Entity
    {
        private readonly AppDbContext _context;

        private readonly Func<AppDbContext, string, Task<T>> GetByIdCompiled =
            EF.CompileAsyncQuery((AppDbContext context, string id)
                =>
            context.Set<T>().FirstOrDefault(p => p.Id == id));
        public DbSet<T> Entity { get; set; }
        public QueryRepository(AppDbContext context)
        {
            _context = context;
            Entity = _context.Set<T>();
        }
        public IQueryable<T> GetAll()
        {
            return Entity.AsQueryable();
        }

        public async Task<T> GetFirstByExpiression(Expression<Func<T, bool>> expression)
        {
            return await Entity.FirstOrDefaultAsync(expression);
        }

        public async Task<T> GetFirstByExpression(Expression<Func<T, bool>> expression)
        {
            return await Entity.FirstOrDefaultAsync(expression);
        }

        public async Task<T> GetFirstById(string id)
        {
            return await GetByIdCompiled(_context, id);
        }

        public IQueryable<T> GetWhere(Expression<Func<T, bool>> expression)
        {
            return Entity.Where(expression);
        }
    }
}
