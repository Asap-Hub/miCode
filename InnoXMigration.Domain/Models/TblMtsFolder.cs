using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblMtsFolder
{
    public int FldIdpk { get; set; }

    public string? FldName { get; set; }

    public string? FldShtName { get; set; }

    public int? FldOrder { get; set; }

    public bool? FldActive { get; set; }

    public string? FldRmks { get; set; }

    public int? FldEditedBy { get; set; }

    public int? FldCreatedBy { get; set; }

    public DateTime? FldCreationDate { get; set; }

    public DateTime? FldEditedDate { get; set; }
}
