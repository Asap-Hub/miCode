using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblHrTrainingModule
{
    public int TmdIdpk { get; set; }

    public string? TmdName { get; set; }

    public string? TmdShtName { get; set; }

    public bool? TmdActive { get; set; }

    public string? TmdRmks { get; set; }

    public int? TmdCreatedby { get; set; }

    public int? TmdEditedBy { get; set; }

    public DateTime? TmdCreationDate { get; set; }

    public DateTime? TmdEditedDate { get; set; }
}
