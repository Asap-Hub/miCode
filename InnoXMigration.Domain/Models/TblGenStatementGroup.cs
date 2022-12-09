using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblGenStatementGroup
{
    public int StgIdpk { get; set; }

    public string? StgName { get; set; }

    public string? StgShtName { get; set; }

    public string? StgCode { get; set; }

    public bool? StgActive { get; set; }

    public string? StgRmks { get; set; }

    public int? StgCreatedBy { get; set; }

    public int? StgEditedBy { get; set; }

    public DateTime? StgCreationDate { get; set; }

    public DateTime? StgEditedDate { get; set; }
}
