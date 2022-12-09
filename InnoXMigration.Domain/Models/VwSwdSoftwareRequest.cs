using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class VwSwdSoftwareRequest
{
    public int SwrIdpk { get; set; }

    public int? SwrRequesterEmpIdfk { get; set; }

    public int? SwrRecommendedByEmpIdfk { get; set; }

    public DateTime? SwrRequestDate { get; set; }

    public DateTime? SwrCompletionDate { get; set; }

    public int? SwrRequesterDeptIdfk { get; set; }

    public int? SwrRequesterSectionIdfk { get; set; }

    public string? SwrUserBase { get; set; }

    public string? SwrProposedName { get; set; }

    public string? SwrFeaturesSummary { get; set; }

    public int? SwrCategoryIdfk { get; set; }

    public string? SwrCancellationRmks { get; set; }

    public string? SwrRecommendationRmks { get; set; }

    public bool SwrRecommended { get; set; }

    public bool SwrApproved { get; set; }

    public bool SwrCancelled { get; set; }

    public int SwrCancelledByEmpIdfk { get; set; }

    public bool SwrSmsSent { get; set; }

    public bool SwrRecommendationSmsSent { get; set; }

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

    public string? SwrCreatedBy { get; set; }

    public int? SwrEditedBy { get; set; }

    public DateTime? SwrCreationDate { get; set; }

    public DateTime? SwrRecommendedOn { get; set; }

    public DateTime? SwrApprovedOn { get; set; }

    public DateTime? SwrCancelledOn { get; set; }

    public DateTime? SwrEditedDate { get; set; }

    public int RequesterEmpId { get; set; }

    public string? RequesterStaffNo { get; set; }

    public string? RequesterLname { get; set; }

    public string? RequesterFname { get; set; }

    public string RequesterOnames { get; set; } = null!;

    public string? RequesterEmpName { get; set; }

    public string? RequesterEmpName1 { get; set; }

    public string? RequesterEmpName2 { get; set; }

    public string? RequesterEmpName3 { get; set; }

    public string? RequesterEmpName4 { get; set; }

    public string? RequesterEmpName5 { get; set; }

    public string? RequesterEmpName6 { get; set; }

    public string? RequesterEmpName7 { get; set; }

    public string? RequesterEmpName8 { get; set; }

    public string? RequesterEmpName9 { get; set; }

    public string? RequesterEmpName10 { get; set; }

    public string? RequesterEmpName11 { get; set; }

    public int RequesterDeptId { get; set; }

    public string RequesterDeptName { get; set; } = null!;

    public string RequesterDeptShtName { get; set; } = null!;

    public int RequesterSxnId { get; set; }

    public string RequesterSxnName { get; set; } = null!;

    public string RequesterSxnShtName { get; set; } = null!;

    public int RequesterLocId { get; set; }

    public string RequesterLocName { get; set; } = null!;

    public string RequesterLocShtName { get; set; } = null!;

    public string RequesterMobNox { get; set; } = null!;

    public string RequesterPlc { get; set; } = null!;

    public string RequesterMobNo { get; set; } = null!;

    public int RequesterJbtId { get; set; }

    public string RequesterJbtName { get; set; } = null!;

    public string RequesterJbtShtName { get; set; } = null!;

    public short RequesterGndId { get; set; }

    public string RequesterGndName { get; set; } = null!;

    public string RequesterGndShtName { get; set; } = null!;

    public int RecommendedByEmpId { get; set; }

    public string RecommendedByStaffNo { get; set; } = null!;

    public string RecommendedByLname { get; set; } = null!;

    public string RecommendedByFname { get; set; } = null!;

    public string RecommendedByOnames { get; set; } = null!;

    public string RecommendedByEmpName { get; set; } = null!;

    public string RecommendedByEmpName1 { get; set; } = null!;

    public string RecommendedByEmpName2 { get; set; } = null!;

    public string RecommendedByEmpName3 { get; set; } = null!;

    public string RecommendedByEmpName4 { get; set; } = null!;

    public string RecommendedByEmpName5 { get; set; } = null!;

    public string RecommendedByEmpName6 { get; set; } = null!;

    public string RecommendedByEmpName7 { get; set; } = null!;

    public string RecommendedByEmpName8 { get; set; } = null!;

    public string RecommendedByEmpName9 { get; set; } = null!;

    public string RecommendedByEmpName10 { get; set; } = null!;

    public string RecommendedByEmpName11 { get; set; } = null!;

    public int RecommendedByDeptId { get; set; }

    public string RecommendedByDeptName { get; set; } = null!;

    public string RecommendedByDeptShtName { get; set; } = null!;

    public int RecommendedBySxnId { get; set; }

    public string RecommendedBySxnName { get; set; } = null!;

    public string RecommendedBySxnShtName { get; set; } = null!;

    public int RecommendedByLocId { get; set; }

    public string RecommendedByLocName { get; set; } = null!;

    public string RecommendedByLocShtName { get; set; } = null!;

    public string RecommendedByMobNox { get; set; } = null!;

    public string RecommendedByPlc { get; set; } = null!;

    public string RecommendedByMobNo { get; set; } = null!;

    public int RecommendedByJbtId { get; set; }

    public string RecommendedByJbtName { get; set; } = null!;

    public string RecommendedByJbtShtName { get; set; } = null!;

    public short RecommendedByGndId { get; set; }

    public string RecommendedByGndName { get; set; } = null!;

    public string RecommendedByGndShtName { get; set; } = null!;

    public int ApproverEmpId { get; set; }

    public string ApproverStaffNo { get; set; } = null!;

    public string ApproverLname { get; set; } = null!;

    public string ApproverFname { get; set; } = null!;

    public string ApproverOnames { get; set; } = null!;

    public string ApproverEmpName { get; set; } = null!;

    public string ApproverEmpName1 { get; set; } = null!;

    public string ApproverEmpName2 { get; set; } = null!;

    public string ApproverEmpName3 { get; set; } = null!;

    public string ApproverEmpName4 { get; set; } = null!;

    public string ApproverEmpName5 { get; set; } = null!;

    public string ApproverEmpName6 { get; set; } = null!;

    public string ApproverEmpName7 { get; set; } = null!;

    public string ApproverEmpName8 { get; set; } = null!;

    public string ApproverEmpName9 { get; set; } = null!;

    public string ApproverEmpName10 { get; set; } = null!;

    public string ApproverEmpName11 { get; set; } = null!;

    public int ApproverDeptId { get; set; }

    public string ApproverDeptName { get; set; } = null!;

    public string ApproverDeptShtName { get; set; } = null!;

    public int ApproverSxnId { get; set; }

    public string ApproverSxnName { get; set; } = null!;

    public string ApproverSxnShtName { get; set; } = null!;

    public int ApproverLocId { get; set; }

    public string ApproverLocName { get; set; } = null!;

    public string ApproverLocShtName { get; set; } = null!;

    public string ApproverMobNox { get; set; } = null!;

    public string ApproverPlc { get; set; } = null!;

    public string ApproverMobNo { get; set; } = null!;

    public int ApproverJbtId { get; set; }

    public string ApproverJbtName { get; set; } = null!;

    public string ApproverJbtShtName { get; set; } = null!;

    public short ApproverGndId { get; set; }

    public string ApproverGndName { get; set; } = null!;

    public string ApproverGndShtName { get; set; } = null!;

    public int? DptIdpk { get; set; }

    public string? DptName { get; set; }

    public string? DptShtName { get; set; }

    public string? DptCode { get; set; }

    public int? SxnIdpk { get; set; }

    public string? SxnName { get; set; }

    public int? SxnDeptIdfk { get; set; }

    public string? SxnShtName { get; set; }

    public string? SxnCode { get; set; }

    public bool? SxnActive { get; set; }

    public string? SwrApprovalRmks { get; set; }

    public int? VrqApprovedByEmpIdfk { get; set; }

    public int SwrNoOfUsers { get; set; }

    public byte? SwrPercentageComplete { get; set; }

    public bool SwrAcknowledged { get; set; }
}
