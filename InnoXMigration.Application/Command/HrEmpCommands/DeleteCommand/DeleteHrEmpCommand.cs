using AutoMapper;
using InnoXMigration.Application.Interface.HrEmp;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InnoXMigration.Application.Command.HrEmpCommands.DeleteCommand
{
    public class DeleteHrEmpCommand : IRequest<int>
    {
        public int EmpkId;
    }

    public class DeleteHrEmpCommandHandler : IRequestHandler<DeleteHrEmpCommand, int>
    {
        private readonly IMapper _mapper;
        private readonly IHrEmp _repository;

        public DeleteHrEmpCommandHandler(IMapper mapper, IHrEmp repository)
        {
            _mapper = mapper;
            _repository = repository;
        }
        public Task<int> Handle(DeleteHrEmpCommand request, CancellationToken cancellationToken)
        {
            return _repository.DeleteHrEmp(request.EmpkId);
        }
    }
}
