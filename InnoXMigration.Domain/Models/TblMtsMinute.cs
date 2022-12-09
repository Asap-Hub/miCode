using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblMtsMinute
{
    public int MntIdpk { get; set; }

    public DateTime? MntDate { get; set; }

    public TimeSpan? MntTimeFrom { get; set; }

    public TimeSpan? MntTimeTo { get; set; }

    public DateTime? MntNextMeeting { get; set; }

    public string? MntTitle { get; set; }

    public string? MntChairPerson { get; set; }

    public int? MntChairPersonEmpIdfk { get; set; }

    public string? MntRecorder { get; set; }

    public int? MntRecorderEmpIdfk { get; set; }

    public string? MntVenue { get; set; }

    public int? MntVenueIdfk { get; set; }

    public bool? MntSchedule { get; set; }

    public string? MntRmks { get; set; }

    public int? MntCreatedBy { get; set; }

    public int? MntEditedBy { get; set; }

    public DateTime? MntCreationDate { get; set; }

    public DateTime? MntEditedDate { get; set; }
}
