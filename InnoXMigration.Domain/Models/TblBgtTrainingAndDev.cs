using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblBgtTrainingAndDev
{
    public int TadIdpk { get; set; }

    public int? TadBudgetIdfk { get; set; }

    public int? TadSectionIdfk { get; set; }

    public int? TadJobTitleIdfk { get; set; }

    public int? TadCourseTitleIdfk { get; set; }

    public short? TadNoOfStaff { get; set; }

    public string? TadSelectedCandidates { get; set; }

    public string? TadCourseObjective { get; set; }

    public string? TadCourseContent { get; set; }

    public int? TadTrainingProviderIdfk { get; set; }

    public string? TadJustification { get; set; }

    public string? TadVenue { get; set; }

    public string? TadMonth { get; set; }

    public decimal? TadCourseFeePerPersonGhc { get; set; }

    public decimal? TadCourseFeePerPersonUsd { get; set; }

    public decimal? TadTotalLocalFee { get; set; }

    public decimal? TadTotalForexFee { get; set; }

    public decimal? TadTotalForexFeeLocalCurrencyEquivalent { get; set; }

    public decimal? TadTotalFee { get; set; }

    public decimal? TadForexCurrencies { get; set; }

    public bool? TadApproved { get; set; }

    public int? TadApprovalDate { get; set; }

    public int? TadApprovedBy { get; set; }

    public string? TadApprovalRmks { get; set; }

    public string? TadRmks { get; set; }

    public int? TadCreatedBy { get; set; }

    public int? TadEditedBy { get; set; }

    public DateTime? TadCreationDate { get; set; }

    public DateTime? TadEditedDate { get; set; }
}
