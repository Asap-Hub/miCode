using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblSsvTrekkingRequest
{
    public int TkrIdpk { get; set; }

    public int? TkrRequesterEmpIdfk { get; set; }

    public int? TkrRecommendedByEmpIdfk { get; set; }

    public int? TkrApprovedByEmpIdfk { get; set; }

    public DateTime? TkrDepartureTime { get; set; }

    public DateTime? TkrArrivalTime { get; set; }

    public int? TkrFromRegionIdfk { get; set; }

    public int? TkrToRegionIdfk { get; set; }

    public string? TkrFromTown { get; set; }

    public string? TkrToTown { get; set; }

    public string? TkrPurpose { get; set; }

    public string? TkrRoute { get; set; }

    public string? TkrSleepOvers { get; set; }

    public string? TkrStopOvers { get; set; }

    public int? TkrCategoryIdfk { get; set; }

    public bool? TkrRecommended { get; set; }

    public DateTime? TkrRecommendedOn { get; set; }

    public string? TkrRecommendRmks { get; set; }

    public bool? TkrApproved { get; set; }

    public DateTime? TkrApprovedOn { get; set; }

    public string? TkrApprovalRmks { get; set; }

    public bool? TkrCancelled { get; set; }

    public int? TkrCancelledByEmpIdfk { get; set; }

    public string? TkrCancelledRmks { get; set; }

    public DateTime? TkrCancelledOn { get; set; }

    public bool? TkrSmsSent { get; set; }

    public bool? TkrActive { get; set; }

    public string? TkrRmks { get; set; }

    public string? TkrCreatedBy { get; set; }

    public int? TkrEditedBy { get; set; }

    public DateTime? TkrCreationDate { get; set; }

    public DateTime? TkrEditedDate { get; set; }
}
