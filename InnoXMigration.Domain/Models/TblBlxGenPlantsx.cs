using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblBlxGenPlantsx
{
    public int FgplIdpk { get; set; }

    public int? FgplGenCompIdfk { get; set; }

    public string? FgplName { get; set; }

    public string? FgplShtName { get; set; }

    public int? FgplPlantTypeIdfk { get; set; }

    public byte? FgplDisplayOrder { get; set; }

    public bool? FgplActive { get; set; }

    public string? FgplRemarks { get; set; }

    public int? FgplCreatedBy { get; set; }

    public int? FgplEditedBy { get; set; }

    public DateTime? FgplCreationDate { get; set; }

    public DateTime? FgplEditedDate { get; set; }
}
