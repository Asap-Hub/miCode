using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblPjmLessonType
{
    public int LtpIdpk { get; set; }

    public string? LtpName { get; set; }

    public string? LtpShtName { get; set; }

    public bool? LtpActive { get; set; }

    public string? LtpRmks { get; set; }

    public int? LtpCreatedBy { get; set; }

    public int? LtpEditedBy { get; set; }

    public DateTime? LtpCreationDate { get; set; }

    public DateTime? LtpEditedDate { get; set; }
}
