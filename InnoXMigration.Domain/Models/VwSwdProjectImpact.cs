using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class VwSwdProjectImpact
{
    public int PimIdpk { get; set; }

    public string? PimName { get; set; }

    public string? PimShtName { get; set; }

    public bool? PimActive { get; set; }

    public int PrcIdpk { get; set; }

    public string? PrcName { get; set; }

    public string? PrcShtName { get; set; }

    public bool? PrcActive { get; set; }

    public string? PrcRmks { get; set; }

    public decimal? PimOrder { get; set; }

    public int? PimProjectCategoryIdfk { get; set; }

    public string? PimRmks { get; set; }
}
