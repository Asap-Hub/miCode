using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class VwGenIssueImpact
{
    public int IimIdpk { get; set; }

    public string? IimName { get; set; }

    public string? IimShtName { get; set; }

    public int? IimIssueTypeIdfk { get; set; }

    public int? IimIssueClassIdfk { get; set; }

    public decimal? IimOrder { get; set; }

    public bool? IimActive { get; set; }

    public string? IimRmks { get; set; }

    public int IclIdpk { get; set; }

    public string? IclName { get; set; }

    public string? IclShtName { get; set; }

    public bool? IclActive { get; set; }

    public string? IclRmks { get; set; }

    public int ItpIdpk { get; set; }

    public string? ItpName { get; set; }

    public string? ItpShtName { get; set; }

    public bool? ItpActive { get; set; }

    public string? ItpRmks { get; set; }
}
