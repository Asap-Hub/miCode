using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblHdsIssuePriority
{
    public int IptIdpk { get; set; }

    public string? IptName { get; set; }

    public string? IptShtName { get; set; }

    public byte? IptOrder { get; set; }

    public bool? IptActive { get; set; }

    public string? IptRmks { get; set; }

    public int? IptCreatedBy { get; set; }

    public int? IptEditedBy { get; set; }

    public DateTime? IptCreationDate { get; set; }

    public DateTime? IptEditedDate { get; set; }
}
