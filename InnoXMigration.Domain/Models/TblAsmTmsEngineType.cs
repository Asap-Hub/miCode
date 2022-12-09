using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblAsmTmsEngineType
{
    public int EgtIdpk { get; set; }

    public string? EgtName { get; set; }

    public string? EgtShtName { get; set; }

    public bool? EgtActive { get; set; }

    public string? EgtRmks { get; set; }

    public string? EgtCreatedBy { get; set; }

    public int? EgtEditedBy { get; set; }

    public DateTime? EgtCreationDate { get; set; }

    public DateTime? EgtEditedDate { get; set; }
}
