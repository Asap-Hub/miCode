using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class VwSftSafetyGroupMember
{
    public int SgmIdpk { get; set; }

    public int? SgmEmpIdfk { get; set; }

    public bool? SgmActive { get; set; }

    public string SgmRmks { get; set; } = null!;

    public int DptIdpk { get; set; }

    public string? DptName { get; set; }

    public string? DptShtName { get; set; }

    public int SxnIdpk { get; set; }

    public string? SxnName { get; set; }

    public string? SxnShtName { get; set; }

    public bool? SxnActive { get; set; }

    public bool? DptActive { get; set; }

    public int EmpDptId { get; set; }

    public string EmpDptName { get; set; } = null!;

    public string EmpDptShtName { get; set; } = null!;

    public int EmpSxnId { get; set; }

    public string EmpSxnName { get; set; } = null!;

    public string EmpSxnShtName { get; set; } = null!;

    public string EmpUntShtName { get; set; } = null!;

    public int EmpUntId { get; set; }

    public string EmpUntName { get; set; } = null!;

    public int SgpIdpk { get; set; }

    public string? SgpName { get; set; }

    public string? SgpShtName { get; set; }

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

    public string? Adname { get; set; }

    public DateTime? EmpDoB { get; set; }

    public DateTime? RetireDate { get; set; }

    public bool EmpVisible { get; set; }

    public bool EmpActive { get; set; }

    public int JobIdpk { get; set; }

    public string JobName { get; set; } = null!;

    public string JobShtName { get; set; } = null!;

    public int JlvIdpk { get; set; }

    public string JlvName { get; set; } = null!;

    public string JlvShtName { get; set; } = null!;

    public string JobTitle { get; set; } = null!;

    public string? RptJobTitle { get; set; }

    public int JbtIdpk { get; set; }

    public string JbtName { get; set; } = null!;

    public string JbtShtName { get; set; } = null!;

    public string EmpMobNo { get; set; } = null!;

    public string EmpTelNo { get; set; } = null!;

    public string EmpIntercom { get; set; } = null!;

    public string EmpOfficialEmail { get; set; } = null!;

    public string EmpMobNox { get; set; } = null!;

    public bool EmpHideMobNo { get; set; }

    public DateTime? SgmStartDate { get; set; }

    public DateTime? SgmEndDate { get; set; }

    public bool SgmSmsSent { get; set; }

    public int SgmSmsCount { get; set; }

    public int? SgmSafetyGroupIdfk { get; set; }

    public short GndIdpk { get; set; }

    public string GndName { get; set; } = null!;

    public string GndshtName { get; set; } = null!;

    public int ApgIdpk { get; set; }

    public string ApgName { get; set; } = null!;

    public string ApgShtName { get; set; } = null!;

    public int AstIdpk { get; set; }

    public string AstName { get; set; } = null!;

    public string AstShtName { get; set; } = null!;

    public int PstIdpk { get; set; }

    public string PstName { get; set; } = null!;

    public string PstShtName { get; set; } = null!;

    public int AscIdpk { get; set; }

    public string AscName { get; set; } = null!;

    public string AscShtName { get; set; } = null!;

    public string EmpMtsName { get; set; } = null!;

    public string EmpMtsShtName { get; set; } = null!;

    public int? LocIdpk { get; set; }

    public string? LocName { get; set; }

    public string? LocShtName { get; set; }

    public bool? LocActive { get; set; }

    public int? AreIdpk { get; set; }

    public string? AreName { get; set; }

    public string? AreShtName { get; set; }

    public bool? AreActive { get; set; }

    public int EmpLocId { get; set; }

    public string EmpLocName { get; set; } = null!;

    public string EmpLocShtName { get; set; } = null!;

    public int EmpAreId { get; set; }

    public string EmpAreName { get; set; } = null!;

    public string EmpAreShtName { get; set; } = null!;

    public bool SgmDeleted { get; set; }

    public DateTime? EmpHireDate { get; set; }

    public int SgmUnitIdfk { get; set; }

    public int UntIdpk { get; set; }

    public string UntName { get; set; } = null!;

    public string UntShtName { get; set; } = null!;

    public int SupEmpId { get; set; }

    public string SupStaffNo { get; set; } = null!;

    public string SupLastname { get; set; } = null!;

    public string SupFirstname { get; set; } = null!;

    public string SupEmpName { get; set; } = null!;

    public string SupEmpName1 { get; set; } = null!;

    public decimal? TenureLeft { get; set; }

    public string SupMobNo { get; set; } = null!;

    public string SupMobNox { get; set; } = null!;

    public bool SupActive { get; set; }

    public bool SupIsStaff { get; set; }
}
