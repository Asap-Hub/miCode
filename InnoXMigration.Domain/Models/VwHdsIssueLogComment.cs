using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class VwHdsIssueLogComment
{
    public int IcmIdpk { get; set; }

    public string? IcmComment { get; set; }

    public bool? IcmActive { get; set; }

    public int? IcmCreatedBy { get; set; }

    public DateTime? IcmCreationDate { get; set; }

    public int EmpIdpk { get; set; }

    public string? EmpStaffNo { get; set; }

    public string? EmpLastName { get; set; }

    public string? EmpFirstName { get; set; }

    public string? EmpName { get; set; }

    public string? EmpName1 { get; set; }

    public string? EmpName2 { get; set; }

    public string? EmpName3 { get; set; }

    public string? EmpName4 { get; set; }

    public int? IcmEmpIdfk { get; set; }

    public int? IcmIssueLogIdfk { get; set; }

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

    public int JbtIdpk { get; set; }

    public string JbtName { get; set; } = null!;

    public string JbtShtName { get; set; } = null!;
}
