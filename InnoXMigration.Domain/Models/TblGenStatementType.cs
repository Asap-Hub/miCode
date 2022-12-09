using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblGenStatementType
{
    public int StpIdpk { get; set; }

    public string? StpName { get; set; }

    public string? StpShtName { get; set; }

    public bool? StpActive { get; set; }

    public string? StpRmks { get; set; }

    public int? StpCreatedBy { get; set; }

    public int? StpEditedBy { get; set; }

    public DateTime? StpCreationDate { get; set; }

    public DateTime? StpEditedDate { get; set; }
}
