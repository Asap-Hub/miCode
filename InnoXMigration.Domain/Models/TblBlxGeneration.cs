using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblBlxGeneration
{
    public int FgnsIdpk { get; set; }

    public int? FgnsGenStationIdfk { get; set; }

    public DateTime? FgnsDate { get; set; }

    public double? FgnsTotGen { get; set; }

    public double? FgnsServStatnInput { get; set; }

    public string? FgnsRemarks { get; set; }

    public int? FgnsCreatedBy { get; set; }

    public int? FgnsEditedBy { get; set; }

    public DateTime? FgnsCreationDate { get; set; }

    public DateTime? FgnsEditedDate { get; set; }
}
