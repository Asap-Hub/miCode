using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblSftMeetingType
{
    public int MtpIdpk { get; set; }

    public string? MtpName { get; set; }

    public string? MtpShtName { get; set; }

    public bool? MtpSafetyMeeting { get; set; }

    public bool? MtpWasacoMeeting { get; set; }

    public bool? MtpOtherMeeting { get; set; }

    public bool? MtpActive { get; set; }

    public string? MtpRmks { get; set; }

    public int? MtpCreatedBy { get; set; }

    public int? MtpEditedBy { get; set; }

    public DateTime? MtpCreationDate { get; set; }

    public DateTime? MtpEditedDate { get; set; }
}
