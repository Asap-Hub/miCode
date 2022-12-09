using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class VwPjmProjectUpdate
{
    public int PupIdpk { get; set; }

    public DateTime? PupDate { get; set; }

    public int? PupProjectIdfk { get; set; }

    public string? PupUpdate { get; set; }

    public decimal? PupPercentComplete { get; set; }

    public DateTime? PupCompletionDate { get; set; }

    public bool? PupActive { get; set; }

    public string? PupRmks { get; set; }

    public int? PjrIdpk { get; set; }

    public DateTime? PjrProposedEndDate { get; set; }

    public DateTime? PjrLastUpdatedOn { get; set; }

    public DateTime? PjrActualEndDate { get; set; }

    public int? StsIdpk { get; set; }

    public string? StsName { get; set; }

    public string? StsShtName { get; set; }

    public bool? StsActive { get; set; }

    public byte? StsOrder { get; set; }

    public int? PupStatusIdfk { get; set; }

    public string? PupCreatedBy { get; set; }

    public int? PupEditedBy { get; set; }

    public DateTime? PupCreationDate { get; set; }

    public DateTime? PupEditedDate { get; set; }

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

    public string? CreatedByEmpName6 { get; set; }

    public string? CreatedByEmpName7 { get; set; }

    public string? CreatedByEmpName8 { get; set; }

    public string? CreatedByEmpName9 { get; set; }

    public string? CreatedByEmpName10 { get; set; }

    public string? CreatedByEmpName11 { get; set; }

    public string? CreatedByDeptShtName { get; set; }

    public string? CreatedBySxnShtName { get; set; }

    public int? CreatedByJobId { get; set; }

    public string? CreatedByJobName { get; set; }

    public string? CreatedByJobTitle { get; set; }

    public int? CreatedByJbtId { get; set; }

    public string? CreatedByJbtName { get; set; }

    public string? CreatedByJbtShtName { get; set; }

    public string? CreatedByMobNo { get; set; }

    public string? CreatedByMobNox { get; set; }

    public string? CreatedByPlc { get; set; }

    public string? CreatedByStaffNo { get; set; }

    public int? ImpIdpk { get; set; }

    public string? ImpName { get; set; }

    public string? ImpShtName { get; set; }

    public decimal? ImpOrder { get; set; }

    public bool? ImpActive { get; set; }

    public string? ImpRmks { get; set; }

    public int? PupImpactIdfk { get; set; }

    public string? PupDoneBy { get; set; }

    public string? PupDoneByDept { get; set; }

    public string PupDoneBySection { get; set; } = null!;

    public string? PupDoneByLocation { get; set; }

    public string PupTag { get; set; } = null!;

    public bool PupLocked { get; set; }

    public bool PupAcknowledged { get; set; }
}
