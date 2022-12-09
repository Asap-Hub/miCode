using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class VwGenScheduleProject
{
    public int ScpIdpk { get; set; }

    public string? ScpName { get; set; }

    public string? ScpShtName { get; set; }

    public int? ScpDeptIdfk { get; set; }

    public int? ScpSectionIdfk { get; set; }

    public DateTime? ScpStartDate { get; set; }

    public DateTime? ScpEndDate { get; set; }

    public DateTime? ScpLastUpdatedOn { get; set; }

    public decimal? ScpCost { get; set; }

    public decimal? ScpPercentComplete { get; set; }

    public string? ScpResources { get; set; }

    public bool? ScpActive { get; set; }

    public string? ScpRmks { get; set; }

    public int? DptIdpk { get; set; }

    public string? DptName { get; set; }

    public string? DptShtName { get; set; }

    public string? DptCode { get; set; }

    public bool? DptActive { get; set; }

    public string? DptRmks { get; set; }

    public int? SxnIdpk { get; set; }

    public string? SxnName { get; set; }

    public string? SxnShtName { get; set; }

    public int? SxnDeptIdfk { get; set; }

    public string? SxnCode { get; set; }

    public bool? SxnActive { get; set; }

    public string? SxnRmks { get; set; }

    public int? UntIdpk { get; set; }

    public string? UntName { get; set; }

    public string? UntShtName { get; set; }

    public string? UntCode { get; set; }

    public bool? UntActive { get; set; }

    public string? UntRmks { get; set; }

    public int? ScpUnitIdfk { get; set; }

    public decimal? ScpReferenceWeight { get; set; }

    public decimal? ScpApplicableWeight { get; set; }

    public decimal? ScpAdjustableWeight { get; set; }

    public decimal? ScpReferencePercentComplete { get; set; }

    public decimal? ScpApplicablePercentComplete { get; set; }

    public decimal? ScpAdjustedPercentComplete { get; set; }

    public string? StartMonthYear { get; set; }

    public string? ScpCreatedBy { get; set; }

    public string? EmpName { get; set; }

    public string? JbtShtName { get; set; }

    public string? Expr1 { get; set; }

    public string? LocShtName { get; set; }

    public string? EmpIntercom { get; set; }

    public DateTime? ScpCreationDate { get; set; }

    public DateTime? ScpEditedDate { get; set; }

    public int? ScpEditedBy { get; set; }
}
