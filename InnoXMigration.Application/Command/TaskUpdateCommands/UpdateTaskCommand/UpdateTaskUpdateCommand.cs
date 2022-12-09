using AutoMapper;
using InnoXMigration.Application.Dtos.TaskDto;
using InnoXMigration.Application.Interface.Task;
using InnoXMigration.Domain.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InnoXMigration.Application.Command.TaskUpdateCommands.UpdateTaskCommand
{
    public class UpdateTaskUpdateCommand: IRequest<int>
    {
        public UpdateTaskUpdateDto TaskDto { get; set; }
    }

    public class UpdateTaskUpdateCommandHandler : IRequestHandler<UpdateTaskUpdateCommand, int>
    {
        private readonly IMapper _mapper;
        private readonly ITaskUpdate _repository;

        public UpdateTaskUpdateCommandHandler(IMapper mapper, ITaskUpdate repository)
        {
            _mapper = mapper;
            _repository = repository;
        }
        public async Task<int> Handle(UpdateTaskUpdateCommand request, CancellationToken cancellationToken)
        {
            var UpdateDto = request.TaskDto;
            var Entity = new TblGenTaskUpdate();
            var MappingDto = _mapper.Map(UpdateDto, Entity);
            var Data = await _repository.UpdateTaskUpdate(MappingDto);
            return Data;
        }
    }
}
