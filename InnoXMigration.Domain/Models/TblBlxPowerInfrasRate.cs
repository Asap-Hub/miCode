using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblBlxPowerInfrasRate
{
    public int FpirIdpk { get; set; }

    public int? FpirCustIdfk { get; set; }

    public double? FpirRate { get; set; }

    public DateTime? FpirDate { get; set; }

    public string? FpirRateTypeIdfk { get; set; }

    public string? FpirRmks { get; set; }

    public int? FpirCreatedBy { get; set; }

    public int? FpirEditedBy { get; set; }

    public DateTime? FpirCreationDate { get; set; }

    public DateTime? FpirEditedDate { get; set; }
}
