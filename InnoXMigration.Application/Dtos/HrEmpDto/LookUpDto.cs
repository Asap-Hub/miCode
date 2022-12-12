using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InnoXMigration.Application.Dtos.HrEmpDto
{
    public class TblHrDeptsDto
    {
        public int DptIdpk { get; set; }

        public string? DptName { get; set; }

    }

    public class TblHrUnitsDto {

        public int UntIdpk { get; set; }

        public string? UntName { get; set; }

    }

    public class TblHrOrgBranchDto
    {
        public int ObrIdpk { get; set; }

        public string? ObrName { get; set; }

    }
}
