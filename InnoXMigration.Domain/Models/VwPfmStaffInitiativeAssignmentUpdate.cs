using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class VwPfmStaffInitiativeAssignmentUpdate
{
    public int SiuIdpk { get; set; }

    public DateTime? SiuDate { get; set; }

    public int? SiuAssignmentIdfk { get; set; }

    public string? SiuUpdate { get; set; }

    public decimal? SiuPercentComplete { get; set; }

    public DateTime? SiuCompletionDate { get; set; }

    public string? SiuDoneBy { get; set; }

    public int CreatedByUserId { get; set; }

    public int CreatedByDeptId { get; set; }

    public string? CreatedByDeptName { get; set; }

    public int? CreatedByLocId { get; set; }

    public string? CreatedByLocName { get; set; }

    public string? CreatedByEmpName { get; set; }

    public string? CreatedByEmpName1 { get; set; }

    public string? CreatedByEmpName2 { get; set; }

    public string CreatedByDeptShtName { get; set; } = null!;

    public string CreatedBySxnShtName { get; set; } = null!;

    public int CreatedByJbtId { get; set; }

    public string CreatedByJbtName { get; set; } = null!;

    public string CreatedByJbtShtName { get; set; } = null!;

    public string? CreatedByEmpName5 { get; set; }

    public string CreatedByMobNo { get; set; } = null!;

    public string CreatedByMobNox { get; set; } = null!;

    public string CreatedByIntercom { get; set; } = null!;

    public string? CreatedByStaffNo { get; set; }

    public int? CreatedByEmpId { get; set; }

    public int AstIdpk { get; set; }

    public string AstName { get; set; } = null!;

    public string AstShtName { get; set; } = null!;

    public bool AstActive { get; set; }

    public int? SiuStatusIdfk { get; set; }

    public DateTime? SiuCreationDate { get; set; }

    public int SiuUniqueIdfk { get; set; }

    public int SuiEmpIdfk { get; set; }
}
