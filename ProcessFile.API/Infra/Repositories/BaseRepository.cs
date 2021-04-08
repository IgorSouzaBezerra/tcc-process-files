using Microsoft.EntityFrameworkCore;
using ProcessFile.API.Domain.Entities;
using ProcessFile.API.Infra.Context;
using ProcessFile.API.Infra.Interfaces;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProcessFile.API.Infra.Repositories
{
    public class BaseRepository<T> : IBaseRepository<T> where T : BaseEntity
    {
        private readonly ApplicationContext _context;

        public BaseRepository(ApplicationContext context)
        {
            _context = context;
        }

        public async Task<T> Create(T entity)
        {
            _context.Add(entity);
            await _context.SaveChangesAsync();

            return entity;
        }

        public async Task<T> Update(T entity)
        {
            _context.Entry(entity).State = EntityState.Modified;
            await _context.SaveChangesAsync();

            return entity;
        }

        public async Task Remove(long id)
        {
            var entity = await Get(id);

            if (entity != null)
            {
                _context.Remove(entity);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<T> Get(long id)
        {
            var entity = await _context.Set<T>().AsNoTracking().Where(x => x.Id == id).ToListAsync();

            return entity.FirstOrDefault();
        }

        public async Task<List<T>> Get()
        {
            return await _context.Set<T>().AsNoTracking().ToListAsync();
        }
    }
}
