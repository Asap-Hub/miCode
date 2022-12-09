using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblPmgInitiative
{
    public int ItvIdpk { get; set; }

    public int? ItvPerspectiveIdfk { get; set; }

    public string? ItvName { get; set; }

    public string? ItvShtName { get; set; }

    public bool? ItvActive { get; set; }

    public string? ItvRmks { get; set; }

    public string? ItvCreatedBy { get; set; }

    public int? ItvEditedBy { get; set; }

    public DateTime? ItvCreationDate { get; set; }

    public DateTime? ItvEditedDate { get; set; }
}
