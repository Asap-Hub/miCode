using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblBlxRegLevyRate
{
    public int FrlrIdpk { get; set; }

    public int? FrlrCustIdfk { get; set; }

    public DateTime? FrlrDate { get; set; }

    public double? FrlrRate { get; set; }

    public string? FrlrRmks { get; set; }

    public int? FrlrCreatedBy { get; set; }

    public int? FrlrEditedBy { get; set; }

    public DateTime? FrlrCreationDate { get; set; }

    public DateTime? FrlrEditedDate { get; set; }
}
