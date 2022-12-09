using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblSlbCheckStationShiftStatus
{
    public int CssIdpk { get; set; }

    public int? CssStationIdfk { get; set; }

    public bool? CssCheck { get; set; }

    public string? CssRmks { get; set; }

    public int? CssCreatedBy { get; set; }

    public int? CssEditedBy { get; set; }

    public DateTime? CssCreationDate { get; set; }

    public DateTime? CssEditedDate { get; set; }
}
