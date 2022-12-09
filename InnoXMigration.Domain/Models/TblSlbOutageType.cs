using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblSlbOutageType
{
    public int OtpIdpk { get; set; }

    public string? OtpName { get; set; }

    public string? OtpShtName { get; set; }

    public bool? OtpPlanned { get; set; }

    public bool? OtpAuto { get; set; }

    public bool? OtpActive { get; set; }

    public string? OtpRmks { get; set; }

    public int? OtpCreatedBy { get; set; }

    public int? OtpEditedBy { get; set; }

    public DateTime? OtpCreationDate { get; set; }

    public DateTime? OtpEditedDate { get; set; }
}
