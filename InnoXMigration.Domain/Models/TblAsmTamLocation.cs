using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblAsmTamLocation
{
    public int TalIdpk { get; set; }

    public string? TalName { get; set; }

    public string? TalShtName { get; set; }

    public bool? TalActive { get; set; }

    public string? TalRmks { get; set; }

    public int? TalCreatedBy { get; set; }

    public int? TalEditedBy { get; set; }

    public DateTime? TalCreationDate { get; set; }

    public DateTime? TalEditedDate { get; set; }
}
