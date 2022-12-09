using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblTbsAncillaryRate
{
    public int AnrIdpk { get; set; }

    public int? AnrCustIdfk { get; set; }

    public double? AnrRate { get; set; }

    public DateTime? AnrDate { get; set; }

    public string? AnrRateTypeIdfk { get; set; }

    public string? AnrRmks { get; set; }

    public int? AnrCreatedBy { get; set; }

    public int? AnrEditedBy { get; set; }

    public DateTime? AnrCreationDate { get; set; }

    public DateTime? AnrEditedDate { get; set; }
}
