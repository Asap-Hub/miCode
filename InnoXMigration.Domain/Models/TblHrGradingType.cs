using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblHrGradingType
{
    public int GdtIdpk { get; set; }

    public string? GdtName { get; set; }

    public string? GdtShtName { get; set; }

    public bool? GdtActive { get; set; }

    public string? GdtRmks { get; set; }

    public int? GdtCreatedBy { get; set; }

    public int? GdtEditedBy { get; set; }

    public DateTime? GdtCreationDate { get; set; }

    public DateTime? GdtEditedDate { get; set; }
}
