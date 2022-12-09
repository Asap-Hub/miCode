using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblHrRoom
{
    public int RomIdpk { get; set; }

    public string? RomName { get; set; }

    public string? RomShtName { get; set; }

    public bool? RomActive { get; set; }

    public string? RomRmks { get; set; }

    public int? RomCreatedBy { get; set; }

    public int? RomEditedBy { get; set; }

    public DateTime? RomCreationDate { get; set; }

    public DateTime? RomEditedDate { get; set; }
}
