using Microsoft.EntityFrameworkCore;
using SeniorProject.Domain.Primitives;
using SeniorProject.Domain.Repository;
using SeniorProject.Persistance.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeniorProject.Persistance.Repository
{
    public class CommandRepository<T> : ICommandRepository<T> where T: Entity
    {//devam edilecek mola
        private readonly AppDbContext _context;
        public CommandRepository(AppDbContext context)
        {
            _context = context;
            Entity=_context.Set<T>();
        }
        public DbSet<T> Entity { get; set; }
        public async Task AddAsync(T entity)
        {
         await Entity.AddAsync(entity);

        }

        public void Remove(T entity)
        {
            Entity.Remove(entity);
        }

        public async Task RemoveByIdAsync(string id)
        {
            T entity = await Entity.FirstAsync(id);
            Remove(entity);

        }

        public void Update(T entity)
        {
            Entity.Update(entity);
        }
    }
}
