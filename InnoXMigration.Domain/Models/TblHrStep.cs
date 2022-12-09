using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblHrStep
{
    public int StpIdpk { get; set; }

    public string? StpName { get; set; }

    public string? StpShtName { get; set; }

    public int? StpGradeIdfk { get; set; }

    public int? StpOrder { get; set; }

    public bool? StpActive { get; set; }

    public string? StpRmks { get; set; }

    public int? StpCreatedBy { get; set; }

    public int? StpEditedBy { get; set; }

    public DateTime? StpCreationDate { get; set; }

    public DateTime? StpEditedDate { get; set; }
}
