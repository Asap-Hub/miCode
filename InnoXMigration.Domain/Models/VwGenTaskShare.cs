using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class VwGenTaskShare
{
    public int TssIdpk { get; set; }

    public int? TssTaskIdfk { get; set; }

    public int? TssEmpIdfk { get; set; }

    public bool? TssSave { get; set; }

    public bool? TssEdit { get; set; }

    public bool? TssRead { get; set; }

    public bool? TssActive { get; set; }

    public int EmpIdpk { get; set; }

    public string? EmpStaffNo { get; set; }

    public string? EmpLastName { get; set; }

    public string? EmpFirstName { get; set; }

    public string EmpOthernames { get; set; } = null!;

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

    public int DptIdpk { get; set; }

    public string DptName { get; set; } = null!;

    public string DptShtName { get; set; } = null!;

    public int SxnIdpk { get; set; }

    public string SxnName { get; set; } = null!;

    public string SxnShtName { get; set; } = null!;

    public int LocIdpk { get; set; }

    public string LocName { get; set; } = null!;

    public string LocShtName { get; set; } = null!;

    public string EmpIntercom { get; set; } = null!;

    public string EmpMobNo { get; set; } = null!;

    public string EmpMobNox { get; set; } = null!;

    public bool EmpIsStaff { get; set; }

    public bool EmpActive { get; set; }

    public int JbtIdpk { get; set; }

    public string JbtName { get; set; } = null!;

    public string JbtShtName { get; set; } = null!;

    public DateTime? TssCreationDate { get; set; }
}
