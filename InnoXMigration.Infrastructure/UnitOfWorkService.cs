using InnoXMigration.Application;
using InnoXMigration.Application.Interface.HrEmp;
using InnoXMigration.Domain.Models;
using InnoXMigration.Infrastructure.Services.HrEmp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InnoXMigration.Infrastructure
{
    public class UnitOfWork : IUnitOfWork
    {
        //dbcontext
        private readonly DbInnoxContext _dbInnoxContext;
        //Base services
        private IBaseService<TblHrEmp> _EmpBaseService;
        private IBaseService<TblHrDept> _DeptBaseService;
        private IBaseService<TblHrOrgBranch> _BranchBaseService;
        //various repository
        private IHrEmp<TblHrOrgBranch> _hrOrgBranch;
        private IHrEmp<TblHrEmp> _hrEmpt;
        private IHrEmp<TblHrDept> _hrDept;
        private IHrEmp<TblHrUnit> _hrUnits;


        public UnitOfWork(
            //dbcontext
            DbInnoxContext dbInnoxContext,
            //base services
            IBaseService<TblHrEmp> EmpBaseService,
            IBaseService<TblHrDept> DeptBaseService,
            IBaseService<TblHrOrgBranch> BranchBaseService,
            //various repository
            IHrEmp<TblHrOrgBranch> hrOrgBranch,
            IHrEmp<TblHrEmp> hrEmp,
            IHrEmp<TblHrDept> hrDept,
            IHrEmp<TblHrUnit> hrUnit
            )
        {
            //dbContext
            _dbInnoxContext = dbInnoxContext;
            //base services
            _EmpBaseService = EmpBaseService;
            _DeptBaseService = DeptBaseService;
            _BranchBaseService = BranchBaseService;
            //various repository
            _hrOrgBranch = hrOrgBranch;
            _hrDept = hrDept;
            _hrEmpt = hrEmp;
            _hrUnits = hrUnit;
        }

        //TblHrEmp BaseService
        public IBaseService<TblHrEmp> EmpBaseService => _EmpBaseService ??= new BaseService<TblHrEmp>(_dbInnoxContext);
        //BaseService
        public IBaseService<TblHrDept> DeptBaseService => _DeptBaseService ??= new BaseService<TblHrDept>(_dbInnoxContext);

        public IBaseService<TblHrOrgBranch> BranchBaseService => _BranchBaseService ??= new BaseService<TblHrOrgBranch>(_dbInnoxContext);

        //Various repository
        public IHrEmp<TblHrOrgBranch> HrBranch  => _hrOrgBranch  ??= new HrEmpService<TblHrOrgBranch>(_dbInnoxContext);


        public IHrEmp<TblHrEmp> HrEmp => _hrEmpt ??= new HrEmpService<TblHrEmp>(_dbInnoxContext);

        public IHrEmp<TblHrDept> HrDept => _hrDept ??= new HrEmpService<TblHrDept>(_dbInnoxContext);

        public IHrEmp<TblHrUnit> HrUnit => _hrUnits ??= new HrEmpService<TblHrUnit>(_dbInnoxContext);   
    }
}
