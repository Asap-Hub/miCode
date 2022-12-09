using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblAsmTamCrossArm
{
    public int CraIdpk { get; set; }

    public string? CraName { get; set; }

    public string? CraShtName { get; set; }

    public bool? CraActive { get; set; }

    public string? CraRmks { get; set; }

    public string? CraCreatedBy { get; set; }

    public int? CraEditedBy { get; set; }

    public DateTime? CraCreationDate { get; set; }

    public DateTime? CraEditedDate { get; set; }
}
