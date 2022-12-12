using InnoXMigration.Application.Interface.HrEmp;
using InnoXMigration.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InnoXMigration.Application
{
    public interface IUnitOfWork
    {
        IBaseService<TblHrDept> DeptBaseService { get; }
        IBaseService<TblHrEmp> EmpBaseService { get; }
        IBaseService<TblHrOrgBranch> BranchBaseService { get; }
        IHrEmp<TblHrDept> HrDept { get; }
        IHrEmp<TblHrEmp> HrEmp { get; }
        IHrEmp<TblHrOrgBranch> HrBranch { get; }
        IHrEmp<TblHrUnit> HrUnit { get; }
    }
}
