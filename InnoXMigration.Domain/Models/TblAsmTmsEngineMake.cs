using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblAsmTmsEngineMake
{
    public int EgmIdpk { get; set; }

    public string? EgmName { get; set; }

    public string? EgmShtName { get; set; }

    public bool? EgmActive { get; set; }

    public string? EgmRmks { get; set; }

    public string? EgmCreatedBy { get; set; }

    public int? EgmEditedBy { get; set; }

    public DateTime? EgmCreationDate { get; set; }

    public DateTime? EgmEditedDate { get; set; }
}
