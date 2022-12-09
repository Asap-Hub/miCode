using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblTbsPowerInfrastructureLevyRate
{
    public int PirIdpk { get; set; }

    public int? PirCustIdfk { get; set; }

    public double? PirRate { get; set; }

    public DateTime? PirDate { get; set; }

    public string? PirRateTypeIdfk { get; set; }

    public string? PirRmks { get; set; }

    public int? PirCreatedBy { get; set; }

    public int? PirEditedBy { get; set; }

    public DateTime? PirCreationDate { get; set; }

    public DateTime? PirEditedDate { get; set; }
}
