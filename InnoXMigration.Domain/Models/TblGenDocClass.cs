using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblGenDocClass
{
    public int GdcIdpk { get; set; }

    public string? GdcName { get; set; }

    public string? GdcShtName { get; set; }

    public bool? GdcActive { get; set; }

    public string? GdcRmks { get; set; }

    public string? GdcCreatedBy { get; set; }

    public int? GdcEditedBy { get; set; }

    public DateTime? GdcCreationDate { get; set; }

    public DateTime? GdcEditedDate { get; set; }
}
