using InnoXMigration.Application.Dtos.TaskDto;
using InnoXMigration.Application.Interface.Task;
using InnoXMigration.Domain.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InnoXMigration.Application.Command.TaskUpdateCommands.GetByIdCommand
{
    public class GetTaskUpdateByIdCommand:IRequest<TblGenTaskUpdate>
    {
        public int Id;
    }

    public class GetTaskUpdateByIdCommandHandler : IRequestHandler<GetTaskUpdateByIdCommand, TblGenTaskUpdate>
    {
        private readonly ITaskUpdate _repository;

        public GetTaskUpdateByIdCommandHandler(ITaskUpdate repository)
        {
            _repository = repository;
        }
        public async Task<TblGenTaskUpdate> Handle(GetTaskUpdateByIdCommand request, CancellationToken cancellationToken)
        {
           return await _repository.GetTaskUpdateByID(request.Id);
        }
    }
}
