using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblAsmTamOtherParameterValue
{
    public int OpvIdpk { get; set; }

    public string? OpvName { get; set; }

    public string? OpvShtName { get; set; }

    public bool? OpvActive { get; set; }

    public string? OpvRmks { get; set; }

    public string? OpvCreatedBy { get; set; }

    public int? OpvEditedBy { get; set; }

    public DateTime? OpvCreationDate { get; set; }

    public DateTime? OpvEditedDate { get; set; }
}
