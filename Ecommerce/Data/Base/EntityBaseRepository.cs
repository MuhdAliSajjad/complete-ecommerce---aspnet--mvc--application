using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace Ecommerce.Data.Base
{
    public class EntityBaseRepository<T> : IEntityBaseRepository<T> where T : class, IEntityBase, new()
    {

        private readonly AppDbContext _context;

        public  EntityBaseRepository(AppDbContext context)
        {
            _context = context;
        }

        //Normal way of typing method
        public async Task AddAsync(T entity)
        {
           await _context.Set<T>().AddAsync(entity);
        }

        //one line typing method
        //public async Task AddAsync(T entity) =>  await _context.Set<T>().AddAsync(entity);
        

        public async Task DeleteAsync(int id)
        {
            var entity = await _context.Set<T>().FirstOrDefaultAsync(n => n.Id == id);
            EntityEntry entityEntry = _context.Entry<T>(entity);
            entityEntry.State = EntityState.Deleted ;
        }

        public async Task<IEnumerable<T>> GetAllAsync()
        {
            //one line of method
            //var result = await _context.Set<T>().ToListAsync();
            return await _context.Set<T>().ToListAsync();
            
        }

        // one line to define function
        public async  Task<T> GetByIdAsync(int id) =>  await _context.Set<T>().FirstOrDefaultAsync(n => n.Id == id);


        public async Task  UpdateAsync(int id, T entity)
        {
            EntityEntry entityEntry = _context.Entry<T>(entity);
            entityEntry.State = EntityState.Modified;
        }
    }
}
