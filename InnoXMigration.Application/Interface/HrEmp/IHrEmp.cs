using InnoXMigration.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace InnoXMigration.Application.Interface.HrEmp
{
    public interface IHrEmp
    {
        Task<int> CreateHrEmp(TblHrEmp tblHrEmp);

        Task<IEnumerable<TblHrEmp>> GetHrEmp();

        Task<TblHrEmp> GetHrEmpByID(int id);

        Task<int> DeleteHrEmp(int id);

        Task<int> UpdateHrEmp(TblHrEmp tblHrEmp);

        Task<IEnumerable<TblHrEmp>> FindHrEmp(Expression<Func<TblHrEmp, bool>> expression);
    }
}
