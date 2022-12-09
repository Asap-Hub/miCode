using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblSvlLogCategory
{
    public int LgcIdpk { get; set; }

    public string? LgcName { get; set; }

    public string? LgcShtName { get; set; }

    public bool? LgcSoftwareRelated { get; set; }

    public bool? LgcHardwareRelated { get; set; }

    public bool? LgcActive { get; set; }

    public string? LgcRmks { get; set; }

    public int? LgcCreatedBy { get; set; }

    public int? LgcEditedBy { get; set; }

    public DateTime? LgcCreationDate { get; set; }

    public DateTime? LgcEditedDate { get; set; }
}
