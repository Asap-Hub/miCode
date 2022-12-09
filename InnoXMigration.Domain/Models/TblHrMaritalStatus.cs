using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblHrMaritalStatus
{
    public int MtsIdpk { get; set; }

    public string MtsName { get; set; } = null!;

    public string MtsShtName { get; set; } = null!;

    public bool? MtsActive { get; set; }

    public string? MtsRmks { get; set; }

    public int? MtsCreatedBy { get; set; }

    public int? MtsEditedBy { get; set; }

    public DateTime? MtsCreationDate { get; set; }

    public DateTime? MtsEditedDate { get; set; }
}
