using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblAsmTmsExamsCategory
{
    public int ExcIdpk { get; set; }

    public string? ExcName { get; set; }

    public string? ExcShtName { get; set; }

    public bool? ExcActive { get; set; }

    public string? ExcRmks { get; set; }

    public string? ExcCreatedBy { get; set; }

    public int? ExcEditedBy { get; set; }

    public DateTime? ExcCreationDate { get; set; }

    public DateTime? ExcEditedDate { get; set; }
}
