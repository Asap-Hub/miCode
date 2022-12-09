using AutoMapper;
using InnoXMigration.Application.Interface.Task;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InnoXMigration.Application.Command.TaskUpdateCommands.DeleteTaskCommand
{
    public class DeleteTaskUpdateCommand: IRequest<int>
    {
        public int Id;
    }
    public class TaskUpdateCommandHandler : IRequestHandler<DeleteTaskUpdateCommand, int>
    {
        private readonly IMapper _mapper;
        private readonly ITaskUpdate _repository;

        public TaskUpdateCommandHandler(IMapper mapper, ITaskUpdate repository)
        {
            _mapper = mapper;
            _repository = repository;
        }
        public async Task<int> Handle(DeleteTaskUpdateCommand request, CancellationToken cancellationToken)
        {
            return await _repository.DeleteTaskUpdate(request.Id);
        }
    }
}
