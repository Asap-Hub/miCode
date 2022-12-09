using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblAsmRstMaintenanceCategory
{
    public int MtcIdpk { get; set; }

    public string? MtcName { get; set; }

    public string? MtcShtName { get; set; }

    public bool? MtcActive { get; set; }

    public string? MtcRmks { get; set; }

    public string? MtcCreatedBy { get; set; }

    public int? MtcEditedBy { get; set; }

    public DateTime? MtcCreationDate { get; set; }

    public DateTime? MtcEditedDate { get; set; }
}
