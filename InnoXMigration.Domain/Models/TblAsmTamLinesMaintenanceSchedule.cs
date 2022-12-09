using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblAsmTamLinesMaintenanceSchedule
{
    public int LmsIdpk { get; set; }

    public string? LmsMainHeader { get; set; }

    public string? LmsTask { get; set; }

    public string? LmsTaskDescription { get; set; }

    public DateTime? LmsStartDate { get; set; }

    public DateTime? LmsEstimatedEndDate { get; set; }

    public DateTime? LmsCompletionDate { get; set; }

    public DateTime? LmsUpdateDate { get; set; }

    public int? LmsPriorityIdfk { get; set; }

    public byte? LmsInitialPercentComplete { get; set; }

    public byte? LmsPercentComplete { get; set; }

    public string? LmsUpdateActivity { get; set; }

    public string? LmsReminder { get; set; }

    public string? LmsLocation { get; set; }

    public string? LmsCategory { get; set; }

    public int? LmsCreatedBy { get; set; }

    public int? LmsEditedBy { get; set; }

    public DateTime? LmsReminderDate { get; set; }

    public DateTime? LmsCreationDate { get; set; }

    public DateTime? LmsEditedDate { get; set; }
}
