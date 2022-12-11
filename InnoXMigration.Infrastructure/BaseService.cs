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
    public class BaseService<TEntity> : IBaseService<TEntity> where TEntity : class
    {
        private readonly DbInnoxContext _DbContext;

        public BaseService(DbInnoxContext DbContext)
        {
            _DbContext = DbContext;
        }
        public async Task<TEntity> CreateDataAsync(TEntity entity)
        {
              await _DbContext.Set<TEntity>().AddAsync(entity);
              await _DbContext.SaveChangesAsync();
            return entity;
             
        }

        public async Task<int> DeleteDataAsync(int id)
        {
            var findData =   _DbContext.Find<TEntity>(id);
            if (findData != null)
            {
                 _DbContext.Set<TEntity>().Remove(findData);
                await _DbContext.SaveChangesAsync();
                
            }
            return 0;
        }
        public async Task<TEntity> GetDataByIdAsync(int id)
        {
            var searchData = await _DbContext.Set<TEntity>().FindAsync(id);
            if (searchData == null)
            {
                return null;
            }
            return searchData;
        }

        public async Task<int> UpdateDataAsync(TEntity entity)
        {
            var data = _DbContext.Set<TEntity>().Update(entity);
              await _DbContext.SaveChangesAsync();
           
            return 0;
        }

       public async Task<IEnumerable<TEntity>> GetDataAsync()
        {

            var Data = await _DbContext.Set<TEntity>().ToListAsync();
            return Data;
        }

        public  async Task<IEnumerable<TEntity>> FindData(Expression<Func<TEntity, bool>> expression)
        {
            IQueryable<TEntity> q = _DbContext.Set<TEntity>().AsQueryable();
            
           q = q.Where(expression);

            return await q.ToListAsync();
        }

        public async Task<List<TEntity>> FromSql(FormattableString Query)
        {
            var Data = await _DbContext.Set<TEntity>().FromSql(sql: Query).ToListAsync();
            return Data;
        }

        public async Task<IEnumerable<TEntity>> FromStoredPro(string StoreProduced)
        {
           var storedProcudure = await _DbContext.Set<TEntity>().FromSqlRaw(StoreProduced).ToListAsync();

            return storedProcudure;
        }
    }
}
