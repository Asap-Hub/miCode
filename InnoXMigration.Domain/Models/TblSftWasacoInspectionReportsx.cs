using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblSftWasacoInspectionReportsx
{
    public int WirIdpk { get; set; }

    public DateTime? WirDate { get; set; }

    public int? WirSafetyGroupIdfk { get; set; }

    public int? WirMeetingDetailIdfk { get; set; }

    public int? WirStationIdfk { get; set; }

    public int? WirLocationIdfk { get; set; }

    public int? WirReportTypeIdfk { get; set; }

    public string? WirObservation { get; set; }

    public string? WirRecommendation { get; set; }

    public string? WirActioners { get; set; }

    public string? WirRectifiers { get; set; }

    public string? WirInspectionTeamLeader { get; set; }

    public string? WirWasacoChairman { get; set; }

    public string? WirTeamMembers { get; set; }

    public bool? WirScoring { get; set; }

    public bool? WirSubmitted { get; set; }

    public int? WirSubmittedByEmpIdfk { get; set; }

    public DateTime? WirSubmittedOn { get; set; }

    public bool? WirActive { get; set; }

    public string? WirRmks { get; set; }

    public int? WirCreatedBy { get; set; }

    public int? WirEditedBy { get; set; }

    public DateTime? WirCreationDate { get; set; }

    public DateTime? WirEditedDate { get; set; }
}
