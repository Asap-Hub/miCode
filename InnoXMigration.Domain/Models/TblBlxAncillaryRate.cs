using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblBlxAncillaryRate
{
    public int FanrIdpk { get; set; }

    public int? FanrCustIdfk { get; set; }

    public double? FanrRate { get; set; }

    public DateTime? FanrDate { get; set; }

    public string? FanrRateTypeIdfk { get; set; }

    public string? FanrRmks { get; set; }

    public int? FanrCreatedBy { get; set; }

    public int? FanrEditedBy { get; set; }

    public DateTime? FanrCreationDate { get; set; }

    public DateTime? FanrEditedDate { get; set; }
}
