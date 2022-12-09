using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblAsmTmsFuelTopupRequest
{
    public int FtrIdpk { get; set; }

    public int? FtrRequestWindowIdfk { get; set; }

    public int? FtrRequesterEmpIdfk { get; set; }

    public int? FtrRecommededByEmpIdfk { get; set; }

    public int? FtrApprovedByEmpIdfk { get; set; }

    public decimal? FtrQuantityRequested { get; set; }

    public decimal? FtrQuantityApproved { get; set; }

    public decimal? FtrQuantityToppedUp { get; set; }

    public int? FtrVehicleDetailIdfk { get; set; }

    public string? FtrApprovalRmks { get; set; }

    public int? FtrRequestTypeIdfk { get; set; }

    public string? FtrCancellationRmks { get; set; }

    public string? FtrPurpose { get; set; }

    public bool? FtrRecommended { get; set; }

    public bool? FtrApproved { get; set; }

    public bool? FtrCancelled { get; set; }

    public int? FtrApproverEmpIdfk { get; set; }

    public int? FtrCancelledByEmpIdfk { get; set; }

    public DateTime? FtrRecommendedOn { get; set; }

    public DateTime? FtrApprovedOn { get; set; }

    public DateTime? FtrCancelledOn { get; set; }

    public bool? FtrSmsSent { get; set; }

    public string? FtrDebitCategory { get; set; }

    public string? FtrCostCenter { get; set; }

    public int? FtrCostCenterIdfk { get; set; }

    public bool? FtrActive { get; set; }

    public string? FtrRmks { get; set; }

    public int? FtrCreatedBy { get; set; }

    public int? FtrEditedBy { get; set; }

    public DateTime? FtrCreationDate { get; set; }

    public DateTime? FtrEditedDate { get; set; }
}
