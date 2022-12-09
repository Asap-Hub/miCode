using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblTdrDept
{
    public int DdpIdpk { get; set; }

    public string? DdpName { get; set; }

    public string? DdpShtName { get; set; }

    public bool? DdpActive { get; set; }

    public string? DdpRmks { get; set; }

    public int? DdpCreatedBy { get; set; }

    public int? DdpEditedBy { get; set; }

    public DateTime? DdpCreationDate { get; set; }

    public DateTime? DdpEditedDate { get; set; }
}
