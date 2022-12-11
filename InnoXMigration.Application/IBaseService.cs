using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace InnoXMigration.Application
{ 
        public interface IBaseService <TEntity> where TEntity : class
        {
            Task<IEnumerable<TEntity>> GetDataAsync();

            Task<TEntity> GetDataByIdAsync(int id);
            Task<int> DeleteDataAsync(int id);

            Task<int> UpdateDataAsync(TEntity entity);
            Task<TEntity> CreateDataAsync(TEntity entity);
            Task<IEnumerable<TEntity>> FindData(Expression<Func<TEntity, bool>> expression);
            Task<List<TEntity>> FromSql(FormattableString source);

            Task<IEnumerable<TEntity>> FromStoredPro(string StoreProduced);
        }
}
