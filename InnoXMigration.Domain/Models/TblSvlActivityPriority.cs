using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblSvlActivityPriority
{
    public int AptIdpk { get; set; }

    public string? AptName { get; set; }

    public string? AptShtName { get; set; }

    public bool? AptActive { get; set; }

    public string? AptRmks { get; set; }

    public int? AptCreatedBy { get; set; }

    public int? AptEditedBy { get; set; }

    public DateTime? AptCreationDate { get; set; }

    public DateTime? AptEditedDate { get; set; }
}
