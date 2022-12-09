using AutoMapper;
using InnoXMigration.Application.Dtos.HrEmpDto;
using InnoXMigration.Application.Dtos.TaskDto;
using InnoXMigration.Application.Interface.HrEmp;
using InnoXMigration.Application.Interface.Task;
using InnoXMigration.Domain.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InnoXMigration.Application.Command.TaskUpdateCommands.CreateTaskCommand
{
    
    public class CreateTaskUpdateCommand : IRequest<int>
    {
        public TaskUpdateDto TaskDto { get; set; }
    }

    public class CreateTaskUpdateCommandHandler : IRequestHandler<CreateTaskUpdateCommand, int>
    {
        private readonly IMapper _mapper;
        private readonly ITaskUpdate _repository;

        public CreateTaskUpdateCommandHandler(IMapper mapper, ITaskUpdate Repository)
        {
            _mapper = mapper;
            _repository = Repository;
        }
        public async Task<int> Handle(CreateTaskUpdateCommand request, CancellationToken cancellationToken)
        {
            var NewDto = request.TaskDto;
            var NewModel = new TblGenTaskUpdate();
            var EstablishMapper = _mapper.Map(NewDto, NewModel);
            var SendToRepository = await _repository.CreateTaskUpdate(EstablishMapper);
            return SendToRepository;

        }
    }
}
