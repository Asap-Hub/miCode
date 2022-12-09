using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblBgtAnnualTarget
{
    public int AntIdpk { get; set; }

    public string? AntName { get; set; }

    public string? AntShtName { get; set; }

    public bool? AntActive { get; set; }

    public string? AntRmks { get; set; }

    public int? AntCreatedBy { get; set; }

    public int? AntEditedBy { get; set; }

    public DateTime? AntCreationDate { get; set; }

    public DateTime? AntEditedDate { get; set; }
}
