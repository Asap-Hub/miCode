using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblHrMaritalStatusx
{
    public int FmtsIdpk { get; set; }

    public string? FmtsName { get; set; }

    public string? FmtsShtName { get; set; }

    public bool? FmtsActive { get; set; }

    public string? FmtsRmks { get; set; }

    public int? FmtsCreatedBy { get; set; }

    public int? FmtsEditedBy { get; set; }

    public DateTime? FmtsCreationDate { get; set; }

    public DateTime? FmtsEditedDate { get; set; }
}
