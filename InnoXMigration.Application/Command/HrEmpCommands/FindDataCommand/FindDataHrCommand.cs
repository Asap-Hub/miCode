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

namespace InnoXMigration.Application.Command.HrEmpCommands.FindDataCommand
{
    public class FindDataHrCommand : IRequest<IEnumerable<TblHrEmp>>
    {
        public EmployeeFilter FilterKey { get; set; }
        public object? FilterValue { get; set; }
    }
    public class FindDataHrCommandHandler : IRequestHandler<FindDataHrCommand, IEnumerable<TblHrEmp>>
    {
        private readonly IHrEmp<TblHrEmp> _repository;

        public FindDataHrCommandHandler(IHrEmp<TblHrEmp> repository)
        {

            _repository = repository;
        }

        public async Task<IEnumerable<TblHrEmp>> Handle(FindDataHrCommand request, CancellationToken cancellationToken)
        {

            switch (request.FilterKey)
            {
                case EmployeeFilter.EmpActive:
                    return await _repository.FindHrEmp(emp => emp.EmpActive == request.FilterValue as bool?);

                case EmployeeFilter.EmpVisible:
                    return await _repository.FindHrEmp(emp => emp.EmpVisible == request.FilterValue as bool?);

                case EmployeeFilter.StaffNo:
                    return await _repository.FindHrEmp(emp => emp.EmpStaffNo == request.FilterValue as string);

                default:
                    throw new ArgumentNullException();

            }

        }
    }
}
