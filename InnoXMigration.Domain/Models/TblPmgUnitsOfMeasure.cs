using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblPmgUnitsOfMeasure
{
    public int UomIdpk { get; set; }

    public string? UomName { get; set; }

    public string? UomShtName { get; set; }

    public bool? UomActive { get; set; }

    public string? UomRmks { get; set; }

    public string? UomCreatedBy { get; set; }

    public int? UomEditedBy { get; set; }

    public DateTime? UomCreationDate { get; set; }

    public DateTime? UomEditedDate { get; set; }
}
