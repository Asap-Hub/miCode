using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblPmsIssueRegister
{
    public int PirIdpk { get; set; }

    public DateTime? PirDateRaised { get; set; }

    public DateTime? PirClosureDate { get; set; }

    public int? PirImpactIdfk { get; set; }

    public int? PirStatusIdfk { get; set; }

    public int? PirSeverityIdfk { get; set; }

    public int? PirProjectIdfk { get; set; }

    public string? PirTitle { get; set; }

    public string? PirShtName { get; set; }

    public int? PirIssueTypeIdfk { get; set; }

    public string? PirDescription { get; set; }

    public string? PirRaisedBy { get; set; }

    public string? PirResponsibleOfficer { get; set; }

    public byte? PirPercentComplete { get; set; }

    public string? PirProgressActivity { get; set; }

    public string? PirLastDoneBy { get; set; }

    public bool? PirLocked { get; set; }

    public bool? PirAcknowledged { get; set; }

    public bool? PirActive { get; set; }

    public string? PirRmks { get; set; }

    public string? PirLastUpdatedBy { get; set; }

    public DateTime? PirLastUpdatedOn { get; set; }

    public string? PirCreatedBy { get; set; }

    public int? PirEditedBy { get; set; }

    public DateTime? PirCreationDate { get; set; }

    public DateTime? PirEditedDate { get; set; }
}
