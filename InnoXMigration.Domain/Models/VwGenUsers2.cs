using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class VwGenUsers2
{
    public int UsaIdpk { get; set; }

    public string? EmpStaffNo { get; set; }

    public int? UsaEmpIdfk { get; set; }

    public string? UsaUsername { get; set; }

    public string? EmpLastName { get; set; }

    public string? EmpFirstName { get; set; }

    public string? EmpOthernames { get; set; }

    public string? EmpName { get; set; }

    public string? EmpName1 { get; set; }

    public string? EmpName2 { get; set; }

    public string? EmpName3 { get; set; }

    public string? EmpName4 { get; set; }

    public string? EmpName5 { get; set; }

    public string? EmpName12 { get; set; }

    public string? EmpName13 { get; set; }

    public string? EmpName15 { get; set; }

    public int? LocIdpk { get; set; }

    public string? LocName { get; set; }

    public int? AreIdpk { get; set; }

    public string? AreName { get; set; }

    public int? DptIdpk { get; set; }

    public string? DptName { get; set; }

    public int? StpIdpk { get; set; }

    public string? StpName { get; set; }

    public int? EmpIdpk { get; set; }

    public string DptShtName { get; set; } = null!;

    public string SxnShtName { get; set; } = null!;

    public int UntIdpk { get; set; }

    public string UntName { get; set; } = null!;

    public string UntShtName { get; set; } = null!;

    public string AreShtName { get; set; } = null!;

    public string LocShtName { get; set; } = null!;

    public string EmpMobNo { get; set; } = null!;

    public string EmpIntercom { get; set; } = null!;

    public int JbtIdpk { get; set; }

    public string JbtName { get; set; } = null!;

    public string JbtShtName { get; set; } = null!;

    public string EmpMobNox { get; set; } = null!;

    public bool EmpActive { get; set; }

    public int? SxnIdpk { get; set; }

    public string? SxnName { get; set; }

    public DateTime? UsaStartDate { get; set; }

    public DateTime? UsaEndDate { get; set; }
}
