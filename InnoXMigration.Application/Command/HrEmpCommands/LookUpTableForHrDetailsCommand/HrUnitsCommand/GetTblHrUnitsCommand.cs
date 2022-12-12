using AutoMapper;
using InnoXMigration.Application.Dtos.HrEmpDto;
using InnoXMigration.Domain.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InnoXMigration.Application.Command.HrEmpCommands.LookUpTableForHrDetailsCommand.HrUnitsCommand
{
    public class GetTblHrUnitsCommand: IRequest<List<TblHrUnitsDto>>
    {
    }
    public class GetTblHrUnitsCommandHandler : IRequestHandler<GetTblHrUnitsCommand, List<TblHrUnitsDto>>
    {
        private readonly IUnitOfWork _repository;
        private readonly IMapper _mapper;

        public GetTblHrUnitsCommandHandler(IUnitOfWork repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        public async Task<List<TblHrUnitsDto>> Handle(GetTblHrUnitsCommand request, CancellationToken cancellationToken)
        {
            var expectingResult = await _repository.HrUnit.GetLookUpDataUsingCommand($"select * from tblHrUnits where  untActive=1 and  untSectionIDfk is not null");

            var MappingExpectedResult = _mapper.Map<List<TblHrUnitsDto>>(expectingResult);

            return MappingExpectedResult;
        }
    }
}
