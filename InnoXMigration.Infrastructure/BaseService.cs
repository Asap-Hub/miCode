using InnoXMigration.Application;
using InnoXMigration.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace InnoXMigration.Infrastructure
{
    public class BaseService:IBaseService
    {
        private readonly DbInnoxContext _DbContext;

        public BaseService(DbInnoxContext DbContext)
        {
            _DbContext = DbContext;
        }
        public async Task<int> CreateDataAsync<TEntity>(TEntity entity) where TEntity : class
        {
            var createData = await _DbContext.AddAsync<TEntity>(entity);
              await _DbContext.SaveChangesAsync();
            return 0;
        }

        public async Task<int> DeleteDataAsync<TEntity>(int id) where TEntity : class
        {
            var findData =   _DbContext.Find<TEntity>(id);
            if (findData != null)
            {
                 _DbContext.Remove(findData);
                await _DbContext.SaveChangesAsync();
            }
            return 0;
        }
        public async Task<TEntity> GetDataByIdAsync<TEntity>(int id) where TEntity : class
        {
            var searchData = await _DbContext.FindAsync<TEntity>(id);
            if (searchData == null)
            {
                return null;
            }
            return searchData;
        }

        public async Task<int> UpdateDataAsync<TEntity>(TEntity entity) where TEntity : class
        {
            var data = _DbContext.Update<TEntity>(entity);
            return await _DbContext.SaveChangesAsync();
            //var searchData = await _DbContext.FindAsync<TEntity>( id );
            //if (searchData != null)
            //{
            
            //}
            //return 0;
        }

       public async Task<IEnumerable<TEntity>> GetDataAsync<TEntity>() where TEntity : class
        {

            var Data = await _DbContext.TblGenTaskUpdates.ToListAsync();
            return (IEnumerable<TEntity>)Data;
        }

        public  async Task<IEnumerable<TEntity>> FindData<TEntity>(Expression<Func<TEntity, bool>> expression) where TEntity : class
        {
            IQueryable<TEntity> q = _DbContext.Set<TEntity>().AsQueryable();
            
           q = q.Where(expression);

            return await q.ToListAsync();
        }
    }
}
