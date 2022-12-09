using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class VwSftWasacoAuditReport
{
    public int WarIdpk { get; set; }

    public int? WarSafetyGroupIdfk { get; set; }

    public int? WarInspectionDetailIdfk { get; set; }

    public int? WarStationIdfk { get; set; }

    public int? WarLocationIdfk { get; set; }

    public DateTime? WarDate { get; set; }

    public int? WarReportTypeIdfk { get; set; }

    public string? WarObservation { get; set; }

    public string? WarRecommendation { get; set; }

    public string? WarInspectionTeamLeader { get; set; }

    public string? WarWasacoChairman { get; set; }

    public bool? WarScoring { get; set; }

    public bool? WarActive { get; set; }

    public string? WarRmks { get; set; }

    public int SgpIdpk { get; set; }

    public string? SgpName { get; set; }

    public string? SgpShtName { get; set; }

    public int WidIdpk { get; set; }

    public string? WidName { get; set; }

    public DateTime? WidStartDate { get; set; }

    public DateTime? WidEndDate { get; set; }

    public bool? WidScoring { get; set; }

    public bool? WidActive { get; set; }

    public int? WrtIdpk { get; set; }

    public string? WrtName { get; set; }

    public string? WrtShtName { get; set; }

    public bool? WrtActive { get; set; }

    public int? WstIdpk { get; set; }

    public string? WstName { get; set; }

    public string? WstShtName { get; set; }

    public bool? WstActive { get; set; }

    public int WlcIdpk { get; set; }

    public string? WlcName { get; set; }

    public string? WlcShtName { get; set; }

    public bool? WlcActive { get; set; }

    public string? WarActioners { get; set; }

    public string? WarRectifiers { get; set; }

    public string? WarTeamMembers { get; set; }

    public bool? WarSubmitted { get; set; }

    public DateTime? WarSubmittedOn { get; set; }

    public bool? WarAcknowledged { get; set; }

    public DateTime? WarAcknowledgedOn { get; set; }
}
