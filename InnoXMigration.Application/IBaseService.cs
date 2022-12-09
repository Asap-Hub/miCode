using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace InnoXMigration.Application
{ 
        public interface IBaseService
        {
            Task<IEnumerable<TEntity>> GetDataAsync<TEntity>() where TEntity : class;

            Task<TEntity> GetDataByIdAsync<TEntity>(int id) where TEntity : class;
            Task<int> DeleteDataAsync<TEntity>(int id) where TEntity : class;

            Task<int> UpdateDataAsync<TEntity>(TEntity entity) where TEntity : class;
            Task<int> CreateDataAsync<TEntity>(TEntity entity) where TEntity : class;
            Task<IEnumerable<TEntity>> FindData<TEntity>(Expression<Func<TEntity, bool>> expression) where TEntity : class;
        }
}
