using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class VwAsmTmsExamRegistration
{
    public int ErgIdpk { get; set; }

    public int? ErgExamNameIdfk { get; set; }

    public int? ErgEmpIdfk { get; set; }

    public bool? ErgActive { get; set; }

    public string? ErgRmks { get; set; }

    public int ExnIdpk { get; set; }

    public string? ExnName { get; set; }

    public string? ExnShtName { get; set; }

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

    public int DptIdpk { get; set; }

    public string DptName { get; set; } = null!;

    public string DptShtName { get; set; } = null!;

    public bool DptActive { get; set; }

    public int SxnIdpk { get; set; }

    public string SxnName { get; set; } = null!;

    public string SxnShtName { get; set; } = null!;

    public int UntIdpk { get; set; }

    public string UntName { get; set; } = null!;

    public string UntShtName { get; set; } = null!;

    public int LocIdpk { get; set; }

    public string LocName { get; set; } = null!;

    public string LocShtName { get; set; } = null!;

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

    public bool JbtActive { get; set; }

    public string EmpMobNo { get; set; } = null!;

    public string EmpTelNo { get; set; } = null!;

    public string EmpIntercom { get; set; } = null!;

    public string EmpOfficialEmail { get; set; } = null!;

    public string EmpMobNox { get; set; } = null!;

    public bool EmpHideMobNo { get; set; }

    public DateTime? ErgWrittenOn { get; set; }

    public bool? ErgPassed { get; set; }

    public DateTime? ErgStartDate { get; set; }

    public DateTime? ErgEndDate { get; set; }

    public bool ErgSmsSent { get; set; }

    public bool ErgSmsCount { get; set; }

    public short ExnDuration { get; set; }

    public short ExnNoOfQuestions { get; set; }

    public bool ExnActive { get; set; }

    public string ExnRmks { get; set; } = null!;
}
