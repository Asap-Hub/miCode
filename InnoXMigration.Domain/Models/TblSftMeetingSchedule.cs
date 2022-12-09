using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblSftMeetingSchedule
{
    public int MscIdpk { get; set; }

    public DateTime? MscDate { get; set; }

    public int? MscMeetingCalendarIdfk { get; set; }

    public int? MscSubmittedByEmpIdfk { get; set; }

    public int? MscAcknowledgedByEmpIdfk { get; set; }

    public int? MscDeletedByEmpIdfk { get; set; }

    public int? MscGroupIdfk { get; set; }

    public int? MscTopicIdfk { get; set; }

    public int? MscResourcePersonIdfk { get; set; }

    public string? MscWhy { get; set; }

    public bool? MscSubmitted { get; set; }

    public bool? MscAcknowledged { get; set; }

    public bool? MscDeleted { get; set; }

    public string? MscDeletionReason { get; set; }

    public bool? MscActive { get; set; }

    public string? MscRmks { get; set; }

    public int? MscCreatedBy { get; set; }

    public int? MscEditedBy { get; set; }

    public DateTime? MscSubmittedOn { get; set; }

    public DateTime? MscAcknowledgedOn { get; set; }

    public DateTime? MscDeletedOn { get; set; }

    public DateTime? MscCreationDate { get; set; }

    public DateTime? MscEditedDate { get; set; }
}
