using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblAsmTamInsulatorType
{
    public int IntIdpk { get; set; }

    public string? IntName { get; set; }

    public string? IntShtName { get; set; }

    public bool? IntActive { get; set; }

    public string? IntRmks { get; set; }

    public string? IntCreatedBy { get; set; }

    public int? IntEditedBy { get; set; }

    public DateTime? IntCreationDate { get; set; }

    public DateTime? IntEditedDate { get; set; }
}
