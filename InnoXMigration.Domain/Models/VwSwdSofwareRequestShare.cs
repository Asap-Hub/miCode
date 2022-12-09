using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class VwSwdSofwareRequestShare
{
    public int SrsIdpk { get; set; }

    public int? SrsEmpIdfk { get; set; }

    public int DptIdpk { get; set; }

    public int SxnIdpk { get; set; }

    public int UntIdpk { get; set; }

    public int LocIdpk { get; set; }

    public int JbtIdpk { get; set; }

    public bool? SrsAdmin { get; set; }

    public bool? SrsUpdate { get; set; }

    public bool? SrsLock { get; set; }

    public bool? SrsRead { get; set; }

    public bool? SrsActive { get; set; }

    public int EmpIdpk { get; set; }

    public string? EmpStaffNo { get; set; }

    public string? EmpLastName { get; set; }

    public string? EmpFirstName { get; set; }

    public string EmpOtherNames { get; set; } = null!;

    public string? EmpName { get; set; }

    public string? EmpName1 { get; set; }

    public string? EmpName2 { get; set; }

    public string? EmpName3 { get; set; }

    public string? EmpName4 { get; set; }

    public string DptName { get; set; } = null!;

    public string DptShtName { get; set; } = null!;

    public string SxnName { get; set; } = null!;

    public string SxnShtName { get; set; } = null!;

    public string UntName { get; set; } = null!;

    public string UntShtName { get; set; } = null!;

    public string LocName { get; set; } = null!;

    public string LocShtName { get; set; } = null!;

    public string JbtName { get; set; } = null!;

    public string JbtShtName { get; set; } = null!;
}
