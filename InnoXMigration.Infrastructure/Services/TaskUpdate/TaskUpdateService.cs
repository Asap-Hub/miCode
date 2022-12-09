using InnoXMigration.Application;
using InnoXMigration.Application.Interface.Task;
using InnoXMigration.Domain.Models;
using InnoXMigration.Infrastructure.Services.HrEmp;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace InnoXMigration.Infrastructure.Services.TaskUpdate
{
    public class TaskUpdateService : ITaskUpdate
    {
        private readonly IBaseService _baseRepository;
        private readonly ILogger<TblGenTaskUpdate> _logger;

        public TaskUpdateService(IBaseService baseRepository, ILogger<TblGenTaskUpdate> logger)
        {
            _baseRepository = baseRepository;
            _logger = logger;
        }
        public async Task<int> CreateTaskUpdate(TblGenTaskUpdate tblTaskUpdate)
        {
            try
            {
                return await _baseRepository.CreateDataAsync(tblTaskUpdate);

            }
            catch (Exception)
            {

                _logger.LogError(message: "Unable to Create New Hr Employee Details ");
                return 0;
            }
        }

        public async Task<int> DeleteTaskUpdate(int id)
        {
            try
            {
                var searchData = await _baseRepository.GetDataByIdAsync<TblGenTaskUpdate>(id);

                if (searchData != null)
                {
                    return await _baseRepository.DeleteDataAsync<TblGenTaskUpdate>(id);
                }

                return 0;
            }
            catch (Exception)
            {
                _logger.LogError(message: "Unable to Delete, kindly check your implementations");
                return 0;
            }
        }

        public async Task<IEnumerable<TblGenTaskUpdate>> FindTaskUpdate(Expression<Func<TblGenTaskUpdate, bool>> expression)
        {
            return await _baseRepository.FindData(expression);
        }

        public async Task<IEnumerable<TblGenTaskUpdate>> GetTaskUpdate()
        {
            return await _baseRepository.GetDataAsync<TblGenTaskUpdate>();
        }

        public async Task<TblGenTaskUpdate> GetTaskUpdateByID(int id)
        {
            return await _baseRepository.GetDataByIdAsync<TblGenTaskUpdate>(id);
        }

        public async Task<int> UpdateTaskUpdate(TblGenTaskUpdate tblTaskUpdate)
        {
            return await _baseRepository.UpdateDataAsync(tblTaskUpdate);
        }
    }
}
