using AutoMapper;
using Azure.Core;
using InnoXMigration.Application.Dtos.HrEmpDto;
using InnoXMigration.Application.Interface.HrEmp;
using InnoXMigration.Domain.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InnoXMigration.Application.Command.HrEmpCommands.LookUpTableForHrDetailsCommand.HrOrgBranchCommand.cs
{
    public class GetHrOrgBranchCommand: IRequest<IEnumerable<TblHrOrgBranchDto>>
    {
       //public TblHrOrgBranchDto Dto { get; set; }
    }
    public class GetHrOrgBranchCommandHandler : IRequestHandler<GetHrOrgBranchCommand, IEnumerable<TblHrOrgBranchDto>>
    {
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _repository;

        public GetHrOrgBranchCommandHandler(IMapper mapper, IUnitOfWork repository)
        {
            _mapper = mapper;
            _repository = repository;
        }
        public async Task<IEnumerable<TblHrOrgBranchDto>> Handle(GetHrOrgBranchCommand request, CancellationToken cancellationToken)
        {
                  
            var expectedResult = await _repository.HrBranch.GetLookUpDataUsingCommand($"select *from tblHrOrgBranches where obrActive=1 and obrName is not null");

            //return expectedResult;
            var result = _mapper.Map<List<TblHrOrgBranchDto>>(expectedResult);
            return result;
        }
    }

}
