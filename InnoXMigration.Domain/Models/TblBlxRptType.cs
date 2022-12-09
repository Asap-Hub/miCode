using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblBlxRptType
{
    public int FrtpIdpk { get; set; }

    public string? FrtpName { get; set; }

    public bool? FrtpPfc { get; set; }

    public bool? FrtpPrl { get; set; }

    public bool? FrtpPtsr { get; set; }

    public bool? FrtpActive { get; set; }

    public string? FrtpRmks { get; set; }

    public int? FrtpCreatedBy { get; set; }

    public int? FrtpEditedBy { get; set; }

    public DateTime? FrtpCreationDate { get; set; }

    public DateTime? FrtpEditedDate { get; set; }
}
