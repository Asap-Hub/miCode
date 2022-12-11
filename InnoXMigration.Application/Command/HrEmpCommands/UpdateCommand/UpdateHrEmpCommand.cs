using AutoMapper;
using InnoXMigration.Application.Dtos.HrEmpDto;
using InnoXMigration.Application.Interface.HrEmp;
using InnoXMigration.Domain.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InnoXMigration.Application.Command.HrEmpCommands.UpdateCommand
{
    public class UpdateHrEmpCommand : IRequest<int>
    {
        public UpdateHrEmpDto updateHrEmpDto { get; set; }
        public int EmpkId;
    }

    public class UpdateHrEmpCommandHandler : IRequestHandler<UpdateHrEmpCommand, int>
    {
        private readonly IHrEmp<TblHrEmp> _repository;
        private readonly IMapper _mapper;

        public UpdateHrEmpCommandHandler(IHrEmp<TblHrEmp> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        public async Task<int> Handle(UpdateHrEmpCommand request, CancellationToken cancellationToken)
        {
            var MainModel = request.updateHrEmpDto;
            var NewModel = new TblHrEmp();
            var Mapping = _mapper.Map(MainModel, NewModel);
            var SendDataToRepo = await _repository.UpdateHrEmp(Mapping);
            return SendDataToRepo;
        }
    }
}
