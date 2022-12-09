using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class VwGenSmsPrivilegesAssignment
{
    public int SpaIdpk { get; set; }

    public bool? SpaActive { get; set; }

    public int EmpIdpk { get; set; }

    public string? EmpStaffNo { get; set; }

    public string? EmpLastName { get; set; }

    public string? EmpFirstName { get; set; }

    public string EmpOthernames { get; set; } = null!;

    public string EmpLegacyName { get; set; } = null!;

    public string? EmpName { get; set; }

    public string? EmpName1 { get; set; }

    public string? EmpName2 { get; set; }

    public string? EmpName3 { get; set; }

    public string? EmpName4 { get; set; }

    public string? EmpFlnamesNoSpace { get; set; }

    public string? EmpLfonamesNoSpace { get; set; }

    public string? EmpLfnamesNoSpace { get; set; }

    public string? SpaRmks { get; set; }

    public int? SpaEmpIdfk { get; set; }

    public int? SpaCreatedBy { get; set; }

    public int? SpaEditedBy { get; set; }

    public DateTime? SpaCreationDate { get; set; }

    public DateTime? SpaEditedDate { get; set; }

    public int LocIdpk { get; set; }

    public string LocName { get; set; } = null!;

    public string LocShtName { get; set; } = null!;

    public int SgpIdpk { get; set; }

    public string? SgpName { get; set; }

    public string? SgpShtName { get; set; }

    public bool? SgpActive { get; set; }

    public string? SgpRmks { get; set; }

    public int? SgpCreatedBy { get; set; }

    public int? SgpEditedBy { get; set; }

    public string EmpMobNox { get; set; } = null!;

    public string EmpMobNo { get; set; } = null!;

    public string EmpIntercom { get; set; } = null!;

    public int DptIdpk { get; set; }

    public string DptName { get; set; } = null!;

    public string DptShtName { get; set; } = null!;

    public int SxnIdpk { get; set; }

    public string SxnName { get; set; } = null!;

    public string SxnShtName { get; set; } = null!;

    public bool SpaApprove { get; set; }

    public bool SpaRecommend { get; set; }

    public bool SpaAlert { get; set; }

    public bool SpaManage { get; set; }

    public string? EmpName12 { get; set; }

    public bool? SpaSend { get; set; }

    public int SpaDailyMax { get; set; }

    public int SpaMonthlyMax { get; set; }
}
