using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class VwGenTaskUpdate
{
    public int TupIdpk { get; set; }

    public DateTime? TupDate { get; set; }

    public int? TupTaskIdfk { get; set; }

    public string? TupUpdate { get; set; }

    public decimal? TupPercentComplete { get; set; }

    public DateTime? TupCompletionDate { get; set; }

    public bool? TupActive { get; set; }

    public string? TupRmks { get; set; }

    public int TskIdpk { get; set; }

    public DateTime? TskStartDate { get; set; }

    public DateTime? TskDueDate { get; set; }

    public DateTime? TskUpdateDate { get; set; }

    public DateTime? TskCompletionDate { get; set; }

    public decimal? TskInitialPercentComplete { get; set; }

    public string? TskAssignedBy { get; set; }

    public string? TskAssignedTo { get; set; }

    public string? TskTask { get; set; }

    public int? TupStatusIdfk { get; set; }

    public string? TupCreatedBy { get; set; }

    public int? TupEditedBy { get; set; }

    public DateTime? TupCreationDate { get; set; }

    public DateTime? TupEditedDate { get; set; }

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

    public string? CreatedByDeptShtName { get; set; }

    public string? CreatedBySxnShtName { get; set; }

    public int? CreatedByJobId { get; set; }

    public string? CreatedByJobName { get; set; }

    public string? CreatedByJobTitle { get; set; }

    public int? CreatedByJbtId { get; set; }

    public string? CreatedByJbtName { get; set; }

    public string? CreatedByJbtShtName { get; set; }

    public string? CreatedByEmpName5 { get; set; }

    public string? CreatedByEmpName6 { get; set; }

    public string? CreatedByEmpName7 { get; set; }

    public string? CreatedByEmpName8 { get; set; }

    public string? CreatedByEmpName9 { get; set; }

    public string? CreatedByEmpName10 { get; set; }

    public string? CreatedByEmpName11 { get; set; }

    public string? CreatedByMobNo { get; set; }

    public string? CreatedByMobNox { get; set; }

    public string? CreatedByIntercom { get; set; }

    public string? CreatedByStaffNo { get; set; }

    public string TupUpdatedBy { get; set; } = null!;

    public bool TupLocked { get; set; }

    public int? CreatedByEmpId { get; set; }

    public int StsIdpk { get; set; }

    public string StsName { get; set; } = null!;

    public string StsShtName { get; set; } = null!;

    public byte StsOrder { get; set; }

    public bool StsActive { get; set; }
}
