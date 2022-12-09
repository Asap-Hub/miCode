using InnoXMigration.Application.Dtos.TaskDto;
using InnoXMigration.Application.Interface.Task;
using InnoXMigration.Domain.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InnoXMigration.Application.Command.TaskUpdateCommands.GetAllCommand
{
    public class GetAllDataCommand: IRequest<IEnumerable<TblGenTaskUpdate>>
    {
        
    }

    public class GetAllDataCommandHandler : IRequestHandler<GetAllDataCommand, IEnumerable<TblGenTaskUpdate>>
    {
        private readonly ITaskUpdate _repository;

        public GetAllDataCommandHandler(ITaskUpdate repository)
        {
            _repository = repository;
        }
        public async Task<IEnumerable<TblGenTaskUpdate>> Handle(GetAllDataCommand request, CancellationToken cancellationToken)
        {
            return await _repository.GetTaskUpdate();
        }
    }

}
