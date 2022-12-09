using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblTbsRegulatoryLevyRate
{
    public int RlrIdpk { get; set; }

    public int? RlrCustIdfk { get; set; }

    public DateTime? RlrDate { get; set; }

    public double? RlrRate { get; set; }

    public string? RlrRmks { get; set; }

    public int? RlrCreatedBy { get; set; }

    public int? RlrEditedBy { get; set; }

    public DateTime? RlrCreationDate { get; set; }

    public DateTime? RlrEditedDate { get; set; }
}
