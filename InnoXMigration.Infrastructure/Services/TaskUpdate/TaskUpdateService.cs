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
        private readonly IBaseService<TblGenTaskUpdate> _baseRepository;
        private readonly ILogger<TblGenTaskUpdate> _logger;

        public TaskUpdateService(IBaseService<TblGenTaskUpdate> baseRepository, ILogger<TblGenTaskUpdate> logger)
        {
            _baseRepository = baseRepository;
            _logger = logger;
        }

        public async Task<TblGenTaskUpdate> CreateTaskUpdate(TblGenTaskUpdate tblTaskUpdate)
        {
             
            return await _baseRepository.CreateDataAsync(tblTaskUpdate);
              

            //}
            //catch (Exception)
            //{

            //    _logger.LogError(message: "Unable to Create New Hr Employee Details ");

            //}
        }

        public async Task<int> DeleteTaskUpdate(int id)
        {
            try
            {
                var searchData = await _baseRepository.GetDataByIdAsync(id);

                if (searchData != null)
                {
                      await _baseRepository.DeleteDataAsync(id);
                    return 0;
                     
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
            return await _baseRepository.GetAllDataAsync();
        }

        public async Task<TblGenTaskUpdate> GetTaskUpdateByID(int id)
        {
            return await _baseRepository.GetDataByIdAsync(id); 
        }

        public async Task<int> UpdateTaskUpdate(TblGenTaskUpdate tblTaskUpdate)
        {
            await _baseRepository.UpdateDataAsync(tblTaskUpdate);
            return 0;
        }


        /*
                public async Task<TblGenTaskUpdate> CreateTaskUpdate(TblGenTaskUpdate tblTaskUpdate)
                {
                    try
                    {
                      var createData =  await _baseRepository.CreateDataAsync(tblTaskUpdate);
                        return tblTaskUpdate;

                    }
                    catch (Exception)
                    {

                        _logger.LogError(message: "Unable to Create New Hr Employee Details ");

                    }
                }


                public async Task DeleteTaskUpdate(int id)
                {
                    try
                    {
                        var searchData = await _baseRepository.GetDataByIdAsync<TblGenTaskUpdate>(id);

                        if (searchData != null)
                        {
                            return await _baseRepository.DeleteDataAsync<TblGenTaskUpdate>(id);
                        }


                    }
                    catch (Exception)
                    {
                        _logger.LogError(message: "Unable to Delete, kindly check your implementations");

                    }
                }

                public async Task<IEnumerable<TblGenTaskUpdate>> FindTaskUpdate(Expression<Func<TblGenTaskUpdate, bool>> expression)
                {
                    return await _baseRepository.FindData(expression);
                }


                public async Task<IEnumerable<TblGenTaskUpdate>> GetTaskUpdate()
                {
                    var data = await _baseRepository.GetDataAsync<TblGenTaskUpdate>();
                }

                public async Task<TblGenTaskUpdate> GetTaskUpdateByID(int id)
                {
                     return await _baseRepository.GetDataByIdAsync<TblGenTaskUpdate>(id);
                }


                public async Task<TblGenTaskUpdate> UpdateTaskUpdate(TblGenTaskUpdate tblTaskUpdate)
                {
                      await _baseRepository.UpdateDataAsync(tblTaskUpdate);
                }

                Task<TblGenTaskUpdate> ITaskUpdate.DeleteTaskUpdate(int id)
                {
                    throw new NotImplementedException();
                }*/
    }
}
