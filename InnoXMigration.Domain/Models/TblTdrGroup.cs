using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblTdrGroup
{
    public int TdgIdpk { get; set; }

    public string? TdgName { get; set; }

    public string? TdgShtName { get; set; }

    public bool? TdgEmp { get; set; }

    public decimal? TdgOrder { get; set; }

    public bool? TdgShowInMainForm { get; set; }

    public bool? TdgActive { get; set; }

    public string? TdgRmks { get; set; }

    public int? TdgCreatedBy { get; set; }

    public int? TdgEditedBy { get; set; }

    public DateTime? TdgCreationDate { get; set; }

    public DateTime? TdgEditedDate { get; set; }
}
