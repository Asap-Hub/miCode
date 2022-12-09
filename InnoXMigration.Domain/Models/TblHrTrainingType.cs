using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblHrTrainingType
{
    public int TtpIdpk { get; set; }

    public string? TtpName { get; set; }

    public string? TtpShtName { get; set; }

    public bool? TtpActive { get; set; }

    public string? TtpRmks { get; set; }

    public int? TtpCreatedby { get; set; }

    public int? TtpEditedBy { get; set; }

    public DateTime? TtpCreationDate { get; set; }

    public DateTime? TtpEditedDate { get; set; }
}
