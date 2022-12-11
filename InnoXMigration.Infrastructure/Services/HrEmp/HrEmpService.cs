using InnoXMigration.Application;
using InnoXMigration.Application.Interface.HrEmp;
using InnoXMigration.Domain.Models;
using Microsoft.Extensions.Logging;
using System.Linq.Expressions;

namespace InnoXMigration.Infrastructure.Services.HrEmp
{
    public class HrEmpService<TEntity> : IHrEmp<TEntity>  where TEntity : class
    {
        private readonly IBaseService<TEntity> _baseRepository;
        private readonly IBaseService<TEntity> _Branch_baseRepository;
        private readonly ILogger<TblHrEmp> _logger;

        private readonly DbInnoxContext dbInnoxContext;

        public HrEmpService(IBaseService<TEntity> baseRepository,
            IBaseService<TEntity> Branch_baseRepository,
            ILogger<TblHrEmp> logger, DbInnoxContext dbInnoxContext)
        {
            _baseRepository = baseRepository;
            _Branch_baseRepository = Branch_baseRepository;
            _logger = logger;
            this.dbInnoxContext = dbInnoxContext;   
        }
        public async Task<int> CreateHrEmp(TEntity entity)
        {
            try
            {
                 await _baseRepository.CreateDataAsync(entity);
                return 0;

            }
            catch (Exception)
            {

                _logger.LogError(message: "Unable to Create New Hr Employee Details ");
                return 0;
            }


        }

        public async Task<int> DeleteHrEmp(int id)
        {

            try
            {
                var searchData = await _baseRepository.GetDataByIdAsync(id);

                if (searchData != null)
                {
                    return await _baseRepository.DeleteDataAsync(id);
                }

                return 0;
            }
            catch (Exception)
            {
                _logger.LogError(message: "Unable to Delete, kindly check your implementations");
                return 0;
            }


        }


        public async Task<IEnumerable<TEntity>> GetHrEmp()
        {
            var data = await _baseRepository.GetDataAsync();
            return data;
        }

        public async Task<TEntity> GetHrEmpByID(int id)
        {
            return await _baseRepository.GetDataByIdAsync(id);
        }

        public async Task<int> UpdateHrEmp(TEntity tblHrEmp)
        {
            return await _baseRepository.UpdateDataAsync(tblHrEmp);
        }

        public async Task<IEnumerable<TEntity>> FindHrEmp(Expression<Func<TEntity, bool>> expression)
        {
            return await _baseRepository.FindData(expression);
        }

        //public async Task<IEnumerable<TblGenCountry>> GetGenActiveCountries()
        //{
        //    //var branch = await _baseRepository.GetLookUp(dbInnoxContext.TblHrOrgBranches.FromSql("EXEC [dbo].[tblHrOrgBranches])").ToListAsync());
        //    var countries = await  dbInnoxContext.TblGenCountries.FromSqlRaw("EXEC [dbo].[spcGenActiveCountries]").ToListAsync();
        //    return countries;
        //}
 
        public async Task<IEnumerable<TEntity>> GetLookUpDataUsingCommand(FormattableString command)
        {
            return await _Branch_baseRepository.FromSql(command);
            
        }

        public Task<IEnumerable<TEntity>> FetchFromStoredProcedure(string command)
        {
            throw new NotImplementedException();
        }

     }
}
