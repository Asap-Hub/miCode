using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class VwSlbUserGroupMember
{
    public int UgmIdpk { get; set; }

    public int? UgmEmpIdfk { get; set; }

    public bool? UgmActive { get; set; }

    public int EmpIdpk { get; set; }

    public string? EmpStaffNo { get; set; }

    public string? EmpLastName { get; set; }

    public string? EmpFirstName { get; set; }

    public string EmpOthernames { get; set; } = null!;

    public string? EmpName { get; set; }

    public string? EmpName1 { get; set; }

    public int DptIdpk { get; set; }

    public string DptName { get; set; } = null!;

    public string DptShtName { get; set; } = null!;

    public int SxnIdpk { get; set; }

    public string SxnName { get; set; } = null!;

    public string SxnShtName { get; set; } = null!;

    public int UntIdpk { get; set; }

    public string UntName { get; set; } = null!;

    public string UntShtName { get; set; } = null!;

    public int LocIdpk { get; set; }

    public string LocName { get; set; } = null!;

    public string LocShtName { get; set; } = null!;

    public string EmpTelNo { get; set; } = null!;

    public string EmpMobNo { get; set; } = null!;

    public string EmpIntercom { get; set; } = null!;

    public string EmpOfficialEmail { get; set; } = null!;

    public string EmpPersonalEmail { get; set; } = null!;

    public int JbtIdpk { get; set; }

    public string JbtName { get; set; } = null!;

    public string JbtShtName { get; set; } = null!;

    public int UgpIdpk { get; set; }

    public string? UgpName { get; set; }

    public string? UgpShtName { get; set; }

    public bool? UgpActive { get; set; }

    public int? UgmGroupIdfk { get; set; }

    public bool EmpIsStaff { get; set; }

    public bool EmpActive { get; set; }

    public string? EmpName2 { get; set; }
}
