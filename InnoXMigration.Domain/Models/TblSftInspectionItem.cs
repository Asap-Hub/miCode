using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblSftInspectionItem
{
    public int IitIdpk { get; set; }

    public string? IitName { get; set; }

    public string? IitShtName { get; set; }

    public bool? IitActive { get; set; }

    public string? IitRmks { get; set; }

    public int? IitCreatedBy { get; set; }

    public int? IitEditedBy { get; set; }

    public DateTime? IitCreationDate { get; set; }

    public DateTime? IitEditedDate { get; set; }
}
