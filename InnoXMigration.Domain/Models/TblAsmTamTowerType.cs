using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblAsmTamTowerType
{
    public int TwtIdpk { get; set; }

    public string? TwtName { get; set; }

    public string? TwtShtName { get; set; }

    public bool? TwtActive { get; set; }

    public string? TwtRmks { get; set; }

    public string? TwtCreatedBy { get; set; }

    public int? TwtEditedBy { get; set; }

    public DateTime? TwtCreationDate { get; set; }

    public DateTime? TwtEditedDate { get; set; }
}
