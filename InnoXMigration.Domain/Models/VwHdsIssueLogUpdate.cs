using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class VwHdsIssueLogUpdate
{
    public int IluIdpk { get; set; }

    public DateTime? IluDate { get; set; }

    public int? IluIssueLogIdfk { get; set; }

    public string? IluUpdate { get; set; }

    public decimal? IluPercentComplete { get; set; }

    public DateTime? IluCompletionDate { get; set; }

    public bool? IluActive { get; set; }

    public string? IluRmks { get; set; }

    public int? IlgIdpk { get; set; }

    public DateTime? IlgDueDate { get; set; }

    public DateTime? IlgUpdateDate { get; set; }

    public DateTime? IlgCompletionDate { get; set; }

    public byte? IlgInitialPercentComplete { get; set; }

    public int? IstIdpk { get; set; }

    public string? IstName { get; set; }

    public string? IstShtName { get; set; }

    public bool? IstActive { get; set; }

    public decimal? IstOrder { get; set; }

    public int? IluStatusIdfk { get; set; }

    public string? IluCreatedBy { get; set; }

    public int? IluEditedBy { get; set; }

    public DateTime? IluCreationDate { get; set; }

    public DateTime? IluEditedDate { get; set; }

    public int CreatedByUserId { get; set; }

    public int CreatedByDeptId { get; set; }

    public string? CreatedByDeptName { get; set; }

    public int? CreatedBySxnId { get; set; }

    public string? CreatedBySxnName { get; set; }

    public int? CreatedByLocId { get; set; }

    public string? CreatedByLocName { get; set; }

    public string? CreatedByEmpName { get; set; }

    public string? CreatedByEmpName1 { get; set; }

    public string? CreatedByEmpName2 { get; set; }

    public string? CreatedByEmpName5 { get; set; }

    public string? CreatedByDeptShtName { get; set; }

    public string? CreatedBySxnShtName { get; set; }

    public int? CreatedByJbtId { get; set; }

    public string? CreatedByJbtName { get; set; }

    public string? CreatedByJbtShtName { get; set; }

    public string? CreatedByMobNo { get; set; }

    public string? CreatedByMobNox { get; set; }

    public string? CreatedByPlc { get; set; }

    public string? CreatedByStaffNo { get; set; }

    public string IluUpdatedBy { get; set; } = null!;

    public string IluUpdatedByDept { get; set; } = null!;

    public string IluUpdateBySection { get; set; } = null!;

    public string IluUpdatedByLocation { get; set; } = null!;

    public int? IimIdpk { get; set; }

    public string? IimName { get; set; }

    public string? IimShtName { get; set; }

    public decimal? IimOrder { get; set; }

    public bool? IimActive { get; set; }

    public string? IimRmks { get; set; }

    public int? IluImpactIdfk { get; set; }
}
