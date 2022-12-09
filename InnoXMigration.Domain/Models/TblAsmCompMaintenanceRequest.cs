using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblAsmCompMaintenanceRequest
{
    public int MrqIdpk { get; set; }

    public DateTime? MrqDate { get; set; }

    public bool? MrqCancelled { get; set; }

    public bool? MrqPm { get; set; }

    public bool? MrqDone { get; set; }

    public bool? MrqOpened { get; set; }

    public bool? MrqApproved { get; set; }

    public bool? MrqAcknowledged { get; set; }

    public int? MrqMaintenanceTypeIdfk { get; set; }

    public DateTime? MrqReportDate { get; set; }

    public int? MrqScheduleWorkshopIdfk { get; set; }

    public int? MrqCompEquipmentIdfk { get; set; }

    public int? MrqReportingStaffEmpIdfk { get; set; }

    public int? MrqRequestedByEmpIdfk { get; set; }

    public int? MrqApprovedByEmpIdfk { get; set; }

    public DateTime? MrqApprovalDate { get; set; }

    public int? MrqAcknowledgedByEmpIdfk { get; set; }

    public DateTime? MrqAcknowledgedOn { get; set; }

    public int? MrqCancelledByEmpIdfk { get; set; }

    public int? MrqWorkshopIdfk { get; set; }

    public string? MrqDefectRequest { get; set; }

    public string? MrqReviewReport { get; set; }

    public decimal? MrqRating { get; set; }

    public decimal? MrqPercentComplete { get; set; }

    public DateTime? MrqCompletionDate { get; set; }

    public DateTime? MrqDateUpdated { get; set; }

    public bool? MrqSmsSent { get; set; }

    public string? MrqRmks { get; set; }

    public int? MrqCreatedBy { get; set; }

    public int? MrqEditedBy { get; set; }

    public DateTime? MrqCancellationDate { get; set; }

    public DateTime? MrqCreationDate { get; set; }

    public DateTime? MrqEditedDate { get; set; }
}
