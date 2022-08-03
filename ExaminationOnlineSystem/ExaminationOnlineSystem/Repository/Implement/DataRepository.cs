using ExaminationOnlineSystem.Common;
using ExaminationOnlineSystem.EF;
using ExaminationOnlineSystem.Repository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExaminationOnlineSystem.Repository.Implement
{
    public class DataRepository<Entity> : IDataRepository<Entity> where Entity : class, IHasId
    {
        private readonly IExamSystemDbContext _context;
        protected readonly DbSet<Entity> DbSet;
        public DataRepository(IExamSystemDbContext context)
        {
            _context = context;
            DbSet = context.Set<Entity>();
        }

        public async Task<Entity> AddAsync(Entity entity)
        {
            await DbSet.AddAsync(entity);
            return entity;
        }


        public async Task<Entity> GetByIdAsync(int id)
        {
            var entity = await DbSet.Where(x => x.Id == id).FirstOrDefaultAsync();
            return entity;
        }

        public Entity Update(Entity entity)
        {
            DbSet.Update(entity);
            return entity;
        }

        public Entity Delete(Entity entity)
        {
            DbSet.Remove(entity);
            return entity;
        }

        public async Task<IEnumerable<TResponse>> GetAllAsync<TResponse>
            (System.Linq.Expressions.Expression<Func<Entity, TResponse>> expression)
        {
            var entities = await DbSet.Select(expression).ToListAsync();
            return entities;
        }
    }
}
