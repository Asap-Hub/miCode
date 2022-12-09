using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblsvlLogStatus
{
    public int LgsIdpk { get; set; }

    public string? LgsName { get; set; }

    public string? LgsShtName { get; set; }

    public bool? LgsInStatus { get; set; }

    public bool? LgsOutStatus { get; set; }

    public bool? LgsActive { get; set; }

    public string? LgsRmks { get; set; }

    public int? LgsCreatedBy { get; set; }

    public int? LgsEditedBy { get; set; }

    public DateTime? LgsCreationDate { get; set; }

    public DateTime? LgsEditedDate { get; set; }
}
