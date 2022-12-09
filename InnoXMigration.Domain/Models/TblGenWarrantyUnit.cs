using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblGenWarrantyUnit
{
    public int WtuIdpk { get; set; }

    public string? WtuName { get; set; }

    public string? WtuShtName { get; set; }

    public int? WtuOrder { get; set; }

    public bool? WtuActive { get; set; }

    public string? WtuRmks { get; set; }

    public string? WtuCreatedBy { get; set; }

    public int? WtuEditedBy { get; set; }

    public DateTime? WtuCreationDate { get; set; }

    public DateTime? WtuEditedDate { get; set; }
}
