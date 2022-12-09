using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblHrReligiousDenomination
{
    public int RdnIdpk { get; set; }

    public string? RdnName { get; set; }

    public string? RdnShtName { get; set; }

    public bool? RdnActive { get; set; }

    public string? RdnRmks { get; set; }

    public int? RdnCreatedBy { get; set; }

    public int? RdnEditedBy { get; set; }

    public DateTime? RdnCreationDate { get; set; }

    public DateTime? RdnEditedDate { get; set; }
}
