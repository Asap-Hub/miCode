using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblSftWasacoAuditReport
{
    public int WarIdpk { get; set; }

    public DateTime? WarDate { get; set; }

    public int? WarSafetyGroupIdfk { get; set; }

    public int? WarInspectionDetailIdfk { get; set; }

    public int? WarStationIdfk { get; set; }

    public int? WarLocationIdfk { get; set; }

    public int? WarReportTypeIdfk { get; set; }

    public string? WarObservation { get; set; }

    public string? WarRecommendation { get; set; }

    public string? WarActioners { get; set; }

    public string? WarRectifiers { get; set; }

    public string? WarInspectionTeamLeader { get; set; }

    public string? WarWasacoChairman { get; set; }

    public string? WarTeamMembers { get; set; }

    public bool? WarScoring { get; set; }

    public bool? WarSubmitted { get; set; }

    public int? WarSubmittedByEmpIdfk { get; set; }

    public DateTime? WarSubmittedOn { get; set; }

    public bool? WarAcknowledged { get; set; }

    public int? WarAcknowledgedByEmpIdfk { get; set; }

    public DateTime? WarAcknowledgedOn { get; set; }

    public bool? WarActive { get; set; }

    public string? WarRmks { get; set; }

    public int? WarCreatedBy { get; set; }

    public int? WarEditedBy { get; set; }

    public DateTime? WarCreationDate { get; set; }

    public DateTime? WarEditedDate { get; set; }
}
