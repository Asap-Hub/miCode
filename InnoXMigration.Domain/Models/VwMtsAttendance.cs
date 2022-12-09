using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class VwMtsAttendance
{
    public int AtdIdpk { get; set; }

    public int? AtdMinuteIdfk { get; set; }

    public int? AtdEmpIdfk { get; set; }

    public string? AtdCategory { get; set; }

    public byte? AtdCategoryNo { get; set; }

    public bool? AtdOwner { get; set; }

    public bool? AtdReader { get; set; }

    public bool? AtdPrint { get; set; }

    public bool? AtdActive { get; set; }

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

    public bool DptActive { get; set; }

    public int SxnIdpk { get; set; }

    public string SxnName { get; set; } = null!;

    public string SxnShtName { get; set; } = null!;

    public int LocIdpk { get; set; }

    public string LocName { get; set; } = null!;

    public string LocShtName { get; set; } = null!;

    public int JbtIdpk { get; set; }

    public string JbtName { get; set; } = null!;

    public string JbtShtName { get; set; } = null!;
}
