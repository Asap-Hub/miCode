using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblSftMeetingAttendanceRemark
{
    public int MarIdpk { get; set; }

    public int? MarMeetingDetailIdfk { get; set; }

    public string? MarRmks { get; set; }

    public int? MarCreatedBy { get; set; }

    public int? MarEditedBy { get; set; }

    public DateTime? MarCreationDate { get; set; }

    public DateTime? MarEditedDate { get; set; }
}
