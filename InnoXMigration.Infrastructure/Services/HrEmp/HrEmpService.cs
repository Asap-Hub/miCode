using InnoXMigration.Application;
using InnoXMigration.Application.Interface.HrEmp;
using InnoXMigration.Domain.Models;
using Microsoft.Extensions.Logging;
using System.Linq.Expressions;

namespace InnoXMigration.Infrastructure.Services.HrEmp
{
    public class HrEmpService<TEntity> : BaseService<TEntity>, IHrEmp<TEntity>  where TEntity : class
    {
        //private readonly ILogger<TblHrEmp> _logger;

        private readonly DbInnoxContext _dbInnoxContext;

        public HrEmpService( DbInnoxContext dbInnoxContext):base(dbInnoxContext)
        { 
            _dbInnoxContext = dbInnoxContext;   
        }

        public async Task<int> CreateHrEmp(TEntity tblHrEmp)
        {
            await base.CreateDataAsync(tblHrEmp); 
            return 0;
            
        }

        public async Task<int> DeleteHrEmp(int id)
        {
            await base.DeleteDataAsync(id);
            return 0;
        }

        public Task<IEnumerable<TEntity>> FetchFromStoredProcedure(string command)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<TEntity>> FindHrEmp(Expression<Func<TEntity, bool>> expression)
        {
            return await base.FindData(expression);
        }

        public async Task<IEnumerable<TEntity>> GetAllHrEmp()
        {
            return await base.GetAllDataAsync();
        }

        public async Task<TEntity> GetHrEmpByID(int id)
        {
            return await base.GetDataByIdAsync(id);
        }

        public async Task<IEnumerable<TEntity>> GetLookUpDataUsingCommand(FormattableString command)
        {
            return await base.FromSql(command);
        }

        public async Task<int> UpdateHrEmp(TEntity tblHrEmp)
        {
            return await base.UpdateDataAsync(tblHrEmp);
        }
        //public async Task<int> CreateHrEmp(TEntity entity)
        //{
        //    try
        //    {
        //         await  _dbInnoxContext.AddAsync(entity);
        //        return 0;

        //    }
        //    catch (Exception)
        //    {

        //        _logger.LogError(message: "Unable to Create New Hr Employee Details ");
        //        return 0;
        //    }


        //}

        //public async Task<int> DeleteHrEmp(int id)
        //{

        //    try
        //    {
        //        var searchData = await _dbInnoxContext.r(id);

        //        if (searchData != null)
        //        {
        //            return await _baseRepository.DeleteDataAsync(id);
        //        }

        //        return 0;
        //    }
        //    catch (Exception)
        //    {
        //        _logger.LogError(message: "Unable to Delete, kindly check your implementations");
        //        return 0;
        //    }


        //}


        //public async Task<IEnumerable<TEntity>> GetHrEmp()
        //{
        //    var data = await _baseRepository.HrOrgBranchRepository.GetHrEmp();
        //    return (IEnumerable<TEntity>)data;
        //}

        //public async Task<TEntity> GetHrEmpByID(int id)
        //{
        //    return await _baseRepository.GetDataByIdAsync(id);
        //}

        //public async Task<int> UpdateHrEmp(TEntity tblHrEmp)
        //{
        //    return await _baseRepository.UpdateDataAsync(tblHrEmp);
        //}

        //public async Task<IEnumerable<TEntity>> FindHrEmp(Expression<Func<TEntity, bool>> expression)
        //{
        //    return await _baseRepository.FindData(expression);
        //}

        ////public async Task<IEnumerable<TblGenCountry>> GetGenActiveCountries()
        ////{
        ////    //var branch = await _baseRepository.GetLookUp(dbInnoxContext.TblHrOrgBranches.FromSql("EXEC [dbo].[tblHrOrgBranches])").ToListAsync());
        ////    var countries = await  dbInnoxContext.TblGenCountries.FromSqlRaw("EXEC [dbo].[spcGenActiveCountries]").ToListAsync();
        ////    return countries;
        ////}

        //public async Task<IEnumerable<TEntity>> GetLookUpDataUsingCommand(FormattableString command)
        //{
        //    return await _Branch_baseRepository.FromSql(command);

        //}

        //public Task<IEnumerable<TEntity>> FetchFromStoredProcedure(string command)
        //{
        //    throw new NotImplementedException();
        //}

    }
}
