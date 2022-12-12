using AutoMapper;
using InnoXMigration.Application.Dtos;
using InnoXMigration.Application.Interface.HrEmp;
using InnoXMigration.Domain.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InnoXMigration.Application.Command.HrEmpCommands.GetAllDataCommand
{
    public class GetAlltHrEmpCommand : IRequest<IEnumerable<TblHrEmp>>
    {
        //public TblHrEmpDto HrEmpDto { get;}
    }
    public class GetAllHrEmpCommandHandler : IRequestHandler<GetAlltHrEmpCommand, IEnumerable<TblHrEmp>>
    {
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _repository;

        public GetAllHrEmpCommandHandler(IMapper mapper, IUnitOfWork repository)
        {
            _mapper = mapper;
            _repository = repository;
        }
        public async Task<IEnumerable<TblHrEmp>> Handle(GetAlltHrEmpCommand request, CancellationToken cancellationToken)
        {
            //var ModelDto = request.HrEmpDto;
            //var MainModel = new TblHrEmp();
            //var mapping = _mapper.Map(ModelDto, MainModel);

            return await _repository.HrEmp.GetAllHrEmp();
        }
    }

}
