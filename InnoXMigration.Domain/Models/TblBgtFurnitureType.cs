using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblBgtFurnitureType
{
    public int FntIdpk { get; set; }

    public string? FntName { get; set; }

    public string? FntShtName { get; set; }

    public bool? FntActive { get; set; }

    public string? FntRmks { get; set; }

    public int? FntCreatedBy { get; set; }

    public int? FntEditedBy { get; set; }

    public DateTime? FntCreationDate { get; set; }

    public DateTime? FntEditedDate { get; set; }
}
