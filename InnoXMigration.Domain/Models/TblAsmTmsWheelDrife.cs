using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblAsmTmsWheelDrife
{
    public int WdrIdpk { get; set; }

    public string? WdrName { get; set; }

    public string? WdrShtName { get; set; }

    public bool? WdrActive { get; set; }

    public string? WdrRmks { get; set; }

    public string? WdrCreatedBy { get; set; }

    public int? WdrEditedBy { get; set; }

    public DateTime? WdrCreationDate { get; set; }

    public DateTime? WdrEditedDate { get; set; }
}
