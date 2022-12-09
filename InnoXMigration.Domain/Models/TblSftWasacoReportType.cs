using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblSftWasacoReportType
{
    public int WrtIdpk { get; set; }

    public string? WrtName { get; set; }

    public string? WrtShtName { get; set; }

    public bool? WrtActive { get; set; }

    public string? WrtRmks { get; set; }

    public int? WrtCreatedBy { get; set; }

    public int? WrtEditedBy { get; set; }

    public DateTime? WrtCreationDate { get; set; }

    public DateTime? WrtEditedDate { get; set; }
}
