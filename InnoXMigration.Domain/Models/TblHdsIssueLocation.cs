using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblHdsIssueLocation
{
    public int IlcIdpk { get; set; }

    public string? IlcName { get; set; }

    public string? IlcShtName { get; set; }

    public short? IlcOrder { get; set; }

    public bool? IlcActive { get; set; }

    public string? IlcRmks { get; set; }

    public int? IlcCreatedBy { get; set; }

    public int? IlcEditedBy { get; set; }

    public DateTime? IlcCreationDate { get; set; }

    public DateTime? IlcEditedDate { get; set; }
}
