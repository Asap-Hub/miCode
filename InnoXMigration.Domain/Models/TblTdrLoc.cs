using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblTdrLoc
{
    public int DlcIdpk { get; set; }

    public string? DlcName { get; set; }

    public string? DlcShtName { get; set; }

    public bool? DlcActive { get; set; }

    public string? DlcRmks { get; set; }

    public int? DlcCreatedBy { get; set; }

    public int? DlcEditedBy { get; set; }

    public DateTime? DlcCreationDate { get; set; }

    public DateTime? DlcEditedDate { get; set; }
}
