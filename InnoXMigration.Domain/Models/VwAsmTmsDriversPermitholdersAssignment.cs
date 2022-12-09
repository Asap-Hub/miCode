using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class VwAsmTmsDriversPermitholdersAssignment
{
    public int DpaIdpk { get; set; }

    public int? DpaEmpIdfk { get; set; }

    public DateTime? DpaStartDate { get; set; }

    public DateTime? DpaEndDate { get; set; }

    public bool? DpaPermitHolder { get; set; }

    public bool? DpaDriver { get; set; }

    public bool? DpaActive { get; set; }

    public string? DpaRmks { get; set; }

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

    public string? EmpName5 { get; set; }

    public string? EmpName6 { get; set; }

    public string? EmpName7 { get; set; }

    public string? EmpName8 { get; set; }

    public string? EmpName9 { get; set; }

    public string? EmpName10 { get; set; }

    public string? EmpName11 { get; set; }

    public string? EmpName12 { get; set; }

    public string? EmpName13 { get; set; }

    public string? EmpName14 { get; set; }

    public string? EmpName15 { get; set; }

    public short GndIdpk { get; set; }

    public string GndName { get; set; } = null!;

    public string GndshtName { get; set; } = null!;

    public int GrdIdpk { get; set; }

    public string GrdName { get; set; } = null!;

    public string GrdShtName { get; set; } = null!;

    public int DptIdpk { get; set; }

    public string DptName { get; set; } = null!;

    public string DptShtName { get; set; } = null!;

    public bool DptActive { get; set; }

    public int SxnIdpk { get; set; }

    public string SxnName { get; set; } = null!;

    public int TitIdpk { get; set; }

    public string TitName { get; set; } = null!;

    public string TitShtName { get; set; } = null!;

    public int LocIdpk { get; set; }

    public string LocName { get; set; } = null!;

    public string LocShtName { get; set; } = null!;

    public string EmpTelNo { get; set; } = null!;

    public string EmpMobNo { get; set; } = null!;

    public string EmpIntercom { get; set; } = null!;

    public string EmpOfficialEmail { get; set; } = null!;

    public string EmpPersonalEmail { get; set; } = null!;

    public string JobName { get; set; } = null!;

    public string JobShtName { get; set; } = null!;

    public bool JobActive { get; set; }

    public int JlvIdpk { get; set; }

    public string JlvName { get; set; } = null!;

    public string JlvShtName { get; set; } = null!;

    public string JobTitle { get; set; } = null!;

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

    public int MtsIdpk { get; set; }

    public string MtsName { get; set; } = null!;

    public string MtsShtName { get; set; } = null!;

    public int JbtIdpk { get; set; }

    public string JbtName { get; set; } = null!;

    public string JbtShtName { get; set; } = null!;

    public string EmpMobNox { get; set; } = null!;

    public string SxnShtName { get; set; } = null!;

    public bool EmpIsStaff { get; set; }

    public bool EmpActive { get; set; }

    public DateTime? RetireDate { get; set; }

    public DateTime? DpaLicenseExpiryDate { get; set; }
}
