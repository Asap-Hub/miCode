using InnoXMigration.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace InnoXMigration.Application.Interface.HrEmp
{
    public interface IHrEmp<TEntity> where TEntity: class
    {
        Task<int> CreateHrEmp(TEntity tblHrEmp);

        Task<IEnumerable<TEntity>> GetHrEmp();

        Task<TEntity> GetHrEmpByID(int id);

        Task<int> DeleteHrEmp(int id);

        Task<int> UpdateHrEmp(TEntity tblHrEmp);

        Task<IEnumerable<TEntity>> FindHrEmp(Expression<Func<TEntity, bool>> expression);

        Task<IEnumerable<TEntity>> GetLookUpDataUsingCommand(FormattableString command);
        Task<IEnumerable<TEntity>> FetchFromStoredProcedure(string command);
    }
}
