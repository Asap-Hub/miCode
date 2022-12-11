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

namespace InnoXMigration.Application.Command.HrEmpCommands.CreateCommand
{
    public class CreateHrEmpCommand : IRequest<int>
    {
        public TblHrEmpDto HrEmpDto { get; set; }
    }

    public class CreateHrEmpCommandHandler : IRequestHandler<CreateHrEmpCommand, int>
    {
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _repository;

        public CreateHrEmpCommandHandler(IMapper mapper, IUnitOfWork Repository)
        {
            _mapper = mapper;
            _repository = Repository;
        }
        public async Task<int> Handle(CreateHrEmpCommand request, CancellationToken cancellationToken)
        {
            var NewDto = request.HrEmpDto;
            var NewModel = new TblHrEmp();
            var EstablishMapper = _mapper.Map(NewDto, NewModel);
            var SendToRepository = await _repository.HrOrgBranchRepository.CreateHrEmp(EstablishMapper);
            return SendToRepository;

        }
    }
}
