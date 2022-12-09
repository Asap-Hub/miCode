using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InnoXMigration.Application.Dtos.HrEmpDto
{
    public class UpdateHrEmpDto
    {
        public int EmpIdpk { get; set; }

        public string? EmpStaffNo { get; set; }

        public string? EmpLastName { get; set; }

        public string? EmpFirstName { get; set; }

        public string? EmpOtherNames { get; set; }

        public string? EmpLegacyName { get; set; }

        public string? EmpInitials { get; set; }

        public string? EmpNickname { get; set; }

        public string? EmpTelNo { get; set; }

        public string? EmpMobNo { get; set; }

        public string? EmpMobNox { get; set; }

        public string? EmpHouseNo { get; set; }

        public string? EmpOfficialEmail { get; set; }

        public string? EmpPersonalEmail { get; set; }

        public string? EmpAddress { get; set; }

        public string? EmpSocSecNo { get; set; }

        public string? EmpNationalId { get; set; }

        public string? EmpOrgUnit { get; set; }

        public string? EmpOrgUnitType { get; set; }

        public string? EmpSupervisorShtTitle { get; set; }

        public string? EmpManagerShtTitle { get; set; }

        public string? EmpDirectorShtTitle { get; set; }

        public string? EmpFacebookAccount { get; set; }

        public string? EmpLinkedIn { get; set; }

        public string? EmpSkype { get; set; }

        public string? EmpTwitterHanlde { get; set; }

        public bool? EmpUpdated { get; set; }

        public bool? EmpActive { get; set; }

        public string? EmpRmks { get; set; }

        public int? EmpCreatedBy { get; set; }

        public int? EmpEditedBy { get; set; }

        public DateTime? EmpCreationDate { get; set; }

        public DateTime? EmpEditedDate { get; set; }
    }
}
