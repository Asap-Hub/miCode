using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class VwSwdProjectUpdate
{
    public int PupIdpk { get; set; }

    public DateTime? PupDate { get; set; }

    public int? PupProjectIdfk { get; set; }

    public string? PupUpdate { get; set; }

    public decimal? PupPercentComplete { get; set; }

    public DateTime? PupCompletionDate { get; set; }

    public bool? PupActive { get; set; }

    public string? PupRmks { get; set; }

    public int? PrjIdpk { get; set; }

    public DateTime? PrjProposedEndDate { get; set; }

    public DateTime? PrjLastUpdatedOn { get; set; }

    public DateTime? PrjActualEndDate { get; set; }

    public int? PstIdpk { get; set; }

    public string? PstName { get; set; }

    public string? PstShtName { get; set; }

    public bool? PstActive { get; set; }

    public decimal? PstOrder { get; set; }

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

    public int? PimIdpk { get; set; }

    public string? PimName { get; set; }

    public string? PimShtName { get; set; }

    public decimal? PimOrder { get; set; }

    public bool? PimActive { get; set; }

    public string? PimRmks { get; set; }

    public int? PupImpactIdfk { get; set; }

    public string? PupDoneBy { get; set; }

    public string? PupDoneByDept { get; set; }

    public string PupDoneBySection { get; set; } = null!;

    public string? PupDoneByLocation { get; set; }
}
