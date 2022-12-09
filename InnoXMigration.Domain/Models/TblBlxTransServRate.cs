using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblBlxTransServRate
{
    public int FtsrIdpk { get; set; }

    public int? FtsrCustIdfk { get; set; }

    public double? FtsrRate { get; set; }

    public DateTime? FtsrDate { get; set; }

    public string? FtsrRmks { get; set; }

    public int? FtsrCreatedBy { get; set; }

    public int? FtsrEditedBy { get; set; }

    public DateTime? FtsrCreationDate { get; set; }

    public DateTime? FtsrEditedDate { get; set; }
}
