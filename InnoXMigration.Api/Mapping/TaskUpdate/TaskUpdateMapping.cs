using AutoMapper;
using InnoXMigration.Application.Dtos.TaskDto;
using InnoXMigration.Domain.Models;

namespace InnoXMigration.Api.Mapping.TaskUpdate
{
    public class TaskUpdateMapping: Profile
    {
        public TaskUpdateMapping()
        {
            CreateMap<TaskUpdateDto, TblGenTaskUpdate>();
            CreateMap<UpdateTaskUpdateDto, TblGenTaskUpdate>();
        }
    }
}
