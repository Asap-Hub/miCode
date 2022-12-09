using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblSftWasacoMeetingAttendancex
{
    public int WmaIdpk { get; set; }

    public DateTime? WmaDate { get; set; }

    public int? WmaSafetyGroupIdfk { get; set; }

    public int? WmaMeetingDetailIdfk { get; set; }

    public int? WmaStationIdfk { get; set; }

    public int? WmaLocationIdfk { get; set; }

    public int? WmaReportTypeIdfk { get; set; }

    public string? WmaObservation { get; set; }

    public string? WmaRecommendation { get; set; }

    public string? WmaActioners { get; set; }

    public string? WmaRectifiers { get; set; }

    public string? WmaInspectionTeamLeader { get; set; }

    public string? WmaWasacoChairman { get; set; }

    public string? WmaTeamMembers { get; set; }

    public bool? WmaScoring { get; set; }

    public bool? WmaSubmitted { get; set; }

    public int? WmaSubmittedByEmpIdfk { get; set; }

    public DateTime? WmaSubmittedOn { get; set; }

    public bool? WmaActive { get; set; }

    public string? WmaRmks { get; set; }

    public int? WmaCreatedBy { get; set; }

    public int? WmaEditedBy { get; set; }

    public DateTime? WmaCreationDate { get; set; }

    public DateTime? WmaEditedDate { get; set; }
}
