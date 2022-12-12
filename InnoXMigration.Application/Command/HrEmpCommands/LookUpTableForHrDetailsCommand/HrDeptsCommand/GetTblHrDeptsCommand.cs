using AutoMapper;
using InnoXMigration.Application.Dtos.HrEmpDto;
using InnoXMigration.Domain.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InnoXMigration.Application.Command.HrEmpCommands.LookUpTableForHrDetailsCommand.HrDeptsCommand
{
    public class GetTblHrDeptsCommand: IRequest<IEnumerable<TblHrDeptsDto>>
    {
    }
    public class GetTblHrDeptsCommandHandler : IRequestHandler<GetTblHrDeptsCommand, IEnumerable<TblHrDeptsDto>>
    {
        private readonly IUnitOfWork _repository;
        private readonly IMapper _mapper;

        public GetTblHrDeptsCommandHandler(IUnitOfWork Repository, IMapper mapper)
        {
            _repository = Repository;
            _mapper = mapper;
        }
        public async Task<IEnumerable<TblHrDeptsDto>> Handle(GetTblHrDeptsCommand request, CancellationToken cancellationToken)
        {
            var result = await _repository.HrDept.GetLookUpDataUsingCommand($"select *from tblHrDepts  where dptactive=1  and dptName is not null");
            var MappingResult = _mapper.Map<List<TblHrDeptsDto>>(result);
            return MappingResult;
             
        }
    }
}
