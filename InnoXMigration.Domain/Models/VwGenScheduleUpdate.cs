using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class VwGenScheduleUpdate
{
    public int ScuIdpk { get; set; }

    public string? ScuScheduleIdfk { get; set; }

    public DateTime? ScuDate { get; set; }

    public decimal? ScuValueComplete { get; set; }

    public decimal? ScuPercentComplete { get; set; }

    public string? ScuUpdateActivity { get; set; }

    public int? ScuCreatedBy { get; set; }

    public string? EmpStaffNo { get; set; }

    public string? UsaUsername { get; set; }

    public string? EmpLastName { get; set; }

    public string? EmpOtherNames { get; set; }

    public string? EmpName { get; set; }

    public string? EmpName1 { get; set; }

    public string? EmpName2 { get; set; }

    public int? LocIdpk { get; set; }

    public string? LocName { get; set; }

    public int SxnIdpk { get; set; }

    public string SxnName { get; set; } = null!;

    public bool? SxnActive { get; set; }

    public int? AreIdpk { get; set; }

    public string? AreName { get; set; }

    public bool? AreActive { get; set; }

    public int? DptIdpk { get; set; }

    public string? DptName { get; set; }

    public int? StpIdpk { get; set; }

    public string DptShtName { get; set; } = null!;

    public string SxnShtName { get; set; } = null!;

    public int UntIdpk { get; set; }

    public string UntName { get; set; } = null!;

    public string UntShtName { get; set; } = null!;

    public string EmpIntercom { get; set; } = null!;

    public string EmpMobNo { get; set; } = null!;

    public int? JobIdpk { get; set; }

    public string? JobName { get; set; }

    public string? EmpName3 { get; set; }

    public string? EmpName4 { get; set; }

    public string? EmpFirstName { get; set; }

    public int JbtIdpk { get; set; }

    public string JbtName { get; set; } = null!;

    public string JbtShtName { get; set; } = null!;

    public DateTime? ScuCreationDate { get; set; }
}
