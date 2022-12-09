using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblHrSalutation
{
    public int SltIdpk { get; set; }

    public string? SltName { get; set; }

    public string? SltShtName { get; set; }

    public bool? SltActive { get; set; }

    public string? SltRmks { get; set; }

    public int? SltCreatedBy { get; set; }

    public int? SltEditedBy { get; set; }

    public DateTime? SltCreationDate { get; set; }

    public DateTime? SltEditedDate { get; set; }
}
