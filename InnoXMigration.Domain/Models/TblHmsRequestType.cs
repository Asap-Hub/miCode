using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblHmsRequestType
{
    public int RtpIdpk { get; set; }

    public string? RtpName { get; set; }

    public string? RtpShtName { get; set; }

    public bool? RtpActive { get; set; }

    public string? RtpRmks { get; set; }

    public string? RtpCreatedBy { get; set; }

    public int? RtpEditedBy { get; set; }

    public DateTime? RtpCreationDate { get; set; }

    public DateTime? RtpEditedDate { get; set; }
}
