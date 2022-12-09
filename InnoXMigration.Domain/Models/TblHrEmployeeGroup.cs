using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblHrEmployeeGroup
{
    public int EgpIdpk { get; set; }

    public string? EgpName { get; set; }

    public string? EgpShtName { get; set; }

    public bool? EgpActive { get; set; }

    public string? EgpRmks { get; set; }

    public int? EgpCreatedBy { get; set; }

    public int? EgpEditedBy { get; set; }

    public DateTime? EgpCreationDate { get; set; }

    public DateTime? EgpEditedDate { get; set; }
}
