using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblHrOvertimeType
{
    public int OttIdpk { get; set; }

    public string OttName { get; set; } = null!;

    public string OttShtName { get; set; } = null!;

    public bool? OttActive { get; set; }

    public string? OttRmks { get; set; }

    public int? OttCreatedBy { get; set; }

    public int? OttEditedBy { get; set; }

    public DateTime? OttCreationDate { get; set; }

    public DateTime? OttEditedDate { get; set; }
}
