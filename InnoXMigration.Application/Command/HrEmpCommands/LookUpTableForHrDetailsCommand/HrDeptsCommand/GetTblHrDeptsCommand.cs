using InnoXMigration.Domain.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InnoXMigration.Application.Command.HrEmpCommands.LookUpTableForHrDetailsCommand.HrDeptsCommand
{
    public class GetTblHrDeptsCommand: IRequest<List<TblHrDept>>
    {
    }
    public class GetTblHrDeptsCommandHandler : IRequestHandler<GetTblHrDeptsCommand, List<TblHrDept>>
    {
        public GetTblHrDeptsCommandHandler()
        {

        }
        public Task<List<TblHrDept>> Handle(GetTblHrDeptsCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
