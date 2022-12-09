using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class VwPjmIssueRegister
{
    public int PirIdpk { get; set; }

    public DateTime? PirDateRaised { get; set; }

    public string? PirDescription { get; set; }

    public string? PirRaisedBy { get; set; }

    public string? PirResponsibleOfficer { get; set; }

    public byte? PirPercentComplete { get; set; }

    public string? PirProgressActivity { get; set; }

    public bool? PirActive { get; set; }

    public string? PirRmks { get; set; }

    public int PitIdpk { get; set; }

    public string? PitName { get; set; }

    public int PimIdpk { get; set; }

    public string? PimName { get; set; }

    public int PmdIdpk { get; set; }

    public string? PmdName { get; set; }

    public string? PsvName { get; set; }

    public int PsvIdpk { get; set; }

    public int PstIdpk { get; set; }

    public string? PstName { get; set; }

    public DateTime? PirClosureDate { get; set; }

    public string? PirTitle { get; set; }
}
