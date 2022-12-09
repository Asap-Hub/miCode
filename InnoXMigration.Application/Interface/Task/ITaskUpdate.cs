using InnoXMigration.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace InnoXMigration.Application.Interface.Task
{
    public interface ITaskUpdate
    {
        Task<int> CreateTaskUpdate(TblGenTaskUpdate tblTaskUpdate);

        Task<IEnumerable<TblGenTaskUpdate>> GetTaskUpdate();

        Task<TblGenTaskUpdate> GetTaskUpdateByID(int id);

        Task<int> DeleteTaskUpdate(int id);

        Task<int> UpdateTaskUpdate(TblGenTaskUpdate tblTaskUpdate);

        Task<IEnumerable<TblGenTaskUpdate>> FindTaskUpdate(Expression<Func<TblGenTaskUpdate, bool>> expression);

    }
}
