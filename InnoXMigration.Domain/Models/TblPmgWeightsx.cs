using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblPmgWeightsx
{
    public int WgtIdpk { get; set; }

    public string? WgtName { get; set; }

    public string? WgtShtName { get; set; }

    public bool? WgtActive { get; set; }

    public string? WgtRmks { get; set; }

    public string? WgtCreatedBy { get; set; }

    public int? WgtEditedBy { get; set; }

    public DateTime? WgtCreationDate { get; set; }

    public DateTime? WgtEditedDate { get; set; }
}
