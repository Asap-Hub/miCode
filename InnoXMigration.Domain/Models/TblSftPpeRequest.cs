using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblSftPpeRequest
{
    public int PrqIdpk { get; set; }

    public int? PrqRequestNo { get; set; }

    public int? PrqRequesterEmpIdfk { get; set; }

    public int? PrqPpeTypeIdfk { get; set; }

    public int? PrqPpeSizeIdfk { get; set; }

    public int? PrqRequestWindowIdfk { get; set; }

    public int? PrqGroupIdfk { get; set; }

    public decimal? PrqQuantityRequested { get; set; }

    public decimal? PrqQuantityRecommended { get; set; }

    public decimal? PrqQuantityAcknowledged { get; set; }

    public decimal? PrqQuantityApproved { get; set; }

    public decimal? PrqQuantityDistributed { get; set; }

    public DateTime? PrqScheduledCollectionDate { get; set; }

    public int? PrqRecommendedByEmpIdfk { get; set; }

    public int? PrqAcknowledgedByEmpIdfk { get; set; }

    public int? PrqApprovedByEmpIdfk { get; set; }

    public DateTime? PrqRecommendedOn { get; set; }

    public DateTime? PrqAcknowledgedOn { get; set; }

    public DateTime? PrqApprovedOn { get; set; }

    public string? PrqApprovalRmks { get; set; }

    public string? PrqCancellationRmks { get; set; }

    public bool? PrqRecommended { get; set; }

    public bool? PrqAcknowledged { get; set; }

    public bool? PrqApproved { get; set; }

    public bool? PrqCancelled { get; set; }

    public int? PrqCancelledByEmpIdfk { get; set; }

    public DateTime? PrqCancelledOn { get; set; }

    public bool? PrqSmsSent { get; set; }

    public string? PrqDebitCategory { get; set; }

    public string? PrqDebit { get; set; }

    public string? PrqDebitDept { get; set; }

    public string? PrqDebitSection { get; set; }

    public bool? PrqActive { get; set; }

    public bool? PrqDistributed { get; set; }

    public DateTime? PrqDistributedOn { get; set; }

    public string? PrqRmks { get; set; }

    public string? PrqCreatedBy { get; set; }

    public int? PrqEditedBy { get; set; }

    public DateTime? PrqCreationDate { get; set; }

    public DateTime? PrqEditedDate { get; set; }
}
