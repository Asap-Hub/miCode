using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblHrCbfAnniversary
{
    public int AnvIdpk { get; set; }

    public string? AnvName { get; set; }

    public string? AnvShtName { get; set; }

    public int? AnvYears { get; set; }

    public bool? AnvActive { get; set; }

    public string? AnvRmks { get; set; }

    public string? AnvCreatedBy { get; set; }

    public int? AnvEditedBy { get; set; }

    public DateTime? AnvCreationDate { get; set; }

    public DateTime? AnvEditedDate { get; set; }
}
