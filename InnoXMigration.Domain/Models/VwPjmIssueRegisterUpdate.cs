using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class VwPjmIssueRegisterUpdate
{
    public int IupIdpk { get; set; }

    public string? IupUpdate { get; set; }

    public decimal? IupPercentComplete { get; set; }

    public DateTime? IupCompletionDate { get; set; }

    public string? IupDoneBy { get; set; }

    public string? IupTag { get; set; }

    public bool? IupActive { get; set; }

    public int PirIdpk { get; set; }

    public int PstIdpk { get; set; }

    public string? PstName { get; set; }

    public int PimIdpk { get; set; }

    public string? PimName { get; set; }

    public string? EmpName1 { get; set; }

    public string? EmpName2 { get; set; }

    public string CreatedByMobNox { get; set; } = null!;

    public string CreatedByPlc { get; set; } = null!;

    public string? CreatedByEmpName { get; set; }

    public string CreatedByJbtName { get; set; } = null!;

    public DateTime? IupDate { get; set; }

    public int? IupIssueRegisterIdfk { get; set; }

    public DateTime? IupCreationDate { get; set; }

    public string? CreatedByStaffNo { get; set; }

    public string CreatedByMobNo { get; set; } = null!;
}
