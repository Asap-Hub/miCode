using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblPmsImpacts2
{
    public int PimIdpk { get; set; }

    public string? PimName { get; set; }

    public string? PimShtName { get; set; }

    public byte? PimOrder { get; set; }

    public bool? PimActive { get; set; }

    public string? PimRmks { get; set; }

    public int? PimCreatedBy { get; set; }

    public int? PimEditedBy { get; set; }

    public DateTime? PimCreationDate { get; set; }

    public DateTime? PimEditedDate { get; set; }
}
