using BRC.Bussiness.Entities.Base;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TRC.Bussiness.Context;

namespace TRC.Bussiness.Repository
{
    public class GenericRepository<T> where T : class, IBaseEntity, new() 
    {
        private readonly TRCDbContext _context;
        public DbSet<T> _set;
        public GenericRepository()
        {
            _context = new TRCDbContext();
            _set = _context.Set<T>();
        }

        public virtual async Task<bool> Add(T entity)
        {
            await _set.AddAsync(entity);
            return true;
        }

        public virtual bool Update(T entity)
        {
            _set.Update(entity);
            return true;
        }
        
        public virtual async Task<IEnumerable<T>> GetAll()
        {
            return await _set.ToListAsync();
        }

        public virtual void Delete(T entity)
        {
            entity.Status = "I";
            Update(entity);
        }

        public virtual async Task<bool> SaveAsync()
        {
            try
            {
                await _context.SaveChangesAsync();
                return true;
            }
            catch (Exception err)
            {
                throw new InvalidOperationException(err.Message);
            }
        }

    }
}
