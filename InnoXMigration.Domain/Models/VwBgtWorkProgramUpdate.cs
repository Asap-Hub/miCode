using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class VwBgtWorkProgramUpdate
{
    public int WpuIdpk { get; set; }

    public DateTime? WpuDate { get; set; }

    public int? WpuWorkProgramIdfk { get; set; }

    public string? WpuUpdate { get; set; }

    public decimal? WpuPercentComplete { get; set; }

    public DateTime? WpuCompletionDate { get; set; }

    public bool? WpuActive { get; set; }

    public string WpuRmks { get; set; } = null!;

    public int? WkpIdpk { get; set; }

    public string? WkpActivity { get; set; }

    public int? StsIdpk { get; set; }

    public string? StsName { get; set; }

    public string? StsShtName { get; set; }

    public bool? StsActive { get; set; }

    public byte? StsOrder { get; set; }

    public int? WpuStatusIdfk { get; set; }

    public string? WpuCreatedBy { get; set; }

    public int? WpuEditedBy { get; set; }

    public DateTime? WpuCreationDate { get; set; }

    public DateTime? WpuEditedDate { get; set; }

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

    public int? BgtIdpk { get; set; }

    public string? BgtName { get; set; }

    public string? BgtShtName { get; set; }

    public DateTime? BgtStartDate { get; set; }

    public DateTime? BgtEndDate { get; set; }

    public string? WkpActivityHeader { get; set; }

    public int? DptIdpk { get; set; }

    public string? DptName { get; set; }

    public string? DptShtName { get; set; }

    public int? SxnIdpk { get; set; }

    public string? SxnName { get; set; }

    public string? SxnShtName { get; set; }

    public string? WpuDoneBy { get; set; }
}
