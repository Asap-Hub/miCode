using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class VwHrStep
{
    public int? GrdIdpk { get; set; }

    public string? GrdName { get; set; }

    public string? GrdShtName { get; set; }

    public bool? GrdActive { get; set; }

    public int StpIdpk { get; set; }

    public string? StpName { get; set; }

    public string? StpShtName { get; set; }

    public int? StpGradeIdfk { get; set; }

    public bool? StpActive { get; set; }

    public string? GrdRmks { get; set; }

    public string? StpRmks { get; set; }

    public int? StpOrder { get; set; }
}
