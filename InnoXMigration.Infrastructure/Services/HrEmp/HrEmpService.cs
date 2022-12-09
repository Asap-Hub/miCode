using InnoXMigration.Application;
using InnoXMigration.Application.Interface.HrEmp;
using InnoXMigration.Domain.Models;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace InnoXMigration.Infrastructure.Services.HrEmp
{
    public class HrEmpService : IHrEmp
    {
        private readonly IBaseService _baseRepository;
        private readonly ILogger<HrEmpService> _logger;

        public HrEmpService(IBaseService baseRepository, ILogger<HrEmpService> logger)
        {
            _baseRepository = baseRepository;
            _logger = logger;
        }
        public async Task<int> CreateHrEmp(TblHrEmp entity)
        {
            try
            {
                return await _baseRepository.CreateDataAsync(entity);

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
                var searchData = await _baseRepository.GetDataByIdAsync<TblHrEmp>(id);

                if (searchData != null)
                {
                    return await _baseRepository.DeleteDataAsync<TblHrEmp>(id);
                }

                return 0;
            }
            catch (Exception)
            {
                _logger.LogError(message: "Unable to Delete, kindly check your implementations");
                return 0;
            }


        }


        public async Task<IEnumerable<TblHrEmp>> GetHrEmp()
        {
            return await _baseRepository.GetDataAsync<TblHrEmp>();
        }

        public async Task<TblHrEmp> GetHrEmpByID(int id)
        {
            return await _baseRepository.GetDataByIdAsync<TblHrEmp>(id);
        }

        public async Task<int> UpdateHrEmp(TblHrEmp tblHrEmp)
        {
            return await _baseRepository.UpdateDataAsync(tblHrEmp);
        }

        public async Task<IEnumerable<TblHrEmp>> FindHrEmp(Expression<Func<TblHrEmp, bool>> expression)
        {
            return await _baseRepository.FindData(expression);
        }

    }
}
