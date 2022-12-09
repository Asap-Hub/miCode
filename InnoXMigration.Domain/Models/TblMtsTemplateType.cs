using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblMtsTemplateType
{
    public int TmtIdpk { get; set; }

    public string? TmtName { get; set; }

    public string? TmtShtName { get; set; }

    public bool? TmtActive { get; set; }

    public string? TmtRmks { get; set; }

    public int? TmtCreatedBy { get; set; }

    public int? TmtEditedBy { get; set; }

    public DateTime? TmtCreationDate { get; set; }

    public DateTime? TmtEditedDate { get; set; }
}
