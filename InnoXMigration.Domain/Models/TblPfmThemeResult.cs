using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblPfmThemeResult
{
    public int TrsIdpk { get; set; }

    public int? TrsThemeIdfk { get; set; }

    public string? TrsResult { get; set; }

    public string? TrsShtResult { get; set; }

    public string? TrsCommentary { get; set; }

    public int? TrsOrder { get; set; }

    public bool? TrsActive { get; set; }

    public string? TrsRmks { get; set; }

    public string? TrsCreatedBy { get; set; }

    public int? TrsEditedBy { get; set; }

    public DateTime? TrsCreationDate { get; set; }

    public DateTime? TrsEditedDate { get; set; }
}
