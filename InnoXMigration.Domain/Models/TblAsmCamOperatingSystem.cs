using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblAsmCamOperatingSystem
{
    public int OpsIdpk { get; set; }

    public string? OpsName { get; set; }

    public string? OpsShtName { get; set; }

    public bool? OpsActive { get; set; }

    public string? OpsRmks { get; set; }

    public int? OpsCreatedBy { get; set; }

    public int? OpsEditedBy { get; set; }

    public DateTime? OpsCreationDate { get; set; }

    public DateTime? OpsEditedDate { get; set; }
}
