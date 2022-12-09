using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblGenTelecomVendor
{
    public int TvdIdpk { get; set; }

    public string? TvdName { get; set; }

    public string? TvdShtName { get; set; }

    public bool? TvdActive { get; set; }

    public string? TvdRmks { get; set; }

    public string? TvdCreatedBy { get; set; }

    public int? TvdEditedBy { get; set; }

    public DateTime? TvdCreationDate { get; set; }

    public DateTime? TvdEditedDate { get; set; }
}
