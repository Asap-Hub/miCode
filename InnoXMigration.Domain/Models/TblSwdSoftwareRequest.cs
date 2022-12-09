using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblSwdSoftwareRequest
{
    public int SwrIdpk { get; set; }

    public int? SwrRequesterEmpIdfk { get; set; }

    public int? SwrRecommendedByEmpIdfk { get; set; }

    public int? VrqApprovedByEmpIdfk { get; set; }

    public DateTime? SwrRequestDate { get; set; }

    public DateTime? SwrCompletionDate { get; set; }

    public int? SwrRequesterDeptIdfk { get; set; }

    public int? SwrRequesterSectionIdfk { get; set; }

    public string? SwrUserBase { get; set; }

    public string? SwrProposedName { get; set; }

    public string? SwrFeaturesSummary { get; set; }

    public int? SwrNoOfUsers { get; set; }

    public byte? SwrPercentageComplete { get; set; }

    public int? SwrCategoryIdfk { get; set; }

    public string? SwrCancellationRmks { get; set; }

    public string? SwrRecommendationRmks { get; set; }

    public bool? SwrRecommended { get; set; }

    public bool? SwrAcknowledged { get; set; }

    public bool? SwrApproved { get; set; }

    public bool? SwrCancelled { get; set; }

    public int? SwrCancelledByEmpIdfk { get; set; }

    public bool? SwrSmsSent { get; set; }

    public bool? SwrRecommendationSmsSent { get; set; }

    public string? SwrDebitCategory { get; set; }

    public string? SwrDebit { get; set; }

    public int? SwrDebitDeptIdfk { get; set; }

    public int? SwrDebitSectionIdfk { get; set; }

    public string? SwrDebitNotes { get; set; }

    public decimal? SwrDebitAmount { get; set; }

    public bool? SwrSatisfied { get; set; }

    public string? SwrSatisfactionRmks { get; set; }

    public bool? SwrActive { get; set; }

    public string? SwrRmks { get; set; }

    public string? SwrApprovalRmks { get; set; }

    public string? SwrCreatedBy { get; set; }

    public int? SwrEditedBy { get; set; }

    public DateTime? SwrCreationDate { get; set; }

    public DateTime? SwrRecommendedOn { get; set; }

    public DateTime? SwrApprovedOn { get; set; }

    public DateTime? SwrCancelledOn { get; set; }

    public DateTime? SwrEditedDate { get; set; }
}
