using AutoMapper;
using InnoXMigration.Application.Interface.HrEmp;
using InnoXMigration.Domain.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InnoXMigration.Application.Command.HrEmpCommands.GetDataCommand
{
    public class GetHrEmpCommand : IRequest<TblHrEmp>
    {
        public int Id;
    }

    public class GetHrEmpCommandHandler : IRequestHandler<GetHrEmpCommand, TblHrEmp>
    {
        private readonly IHrEmp _repository;
        private readonly IMapper _mapper;

        public GetHrEmpCommandHandler(IHrEmp repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        public async Task<TblHrEmp> Handle(GetHrEmpCommand request, CancellationToken cancellationToken)
        {
            return await _repository.GetHrEmpByID(request.Id);
        }
    }
}
