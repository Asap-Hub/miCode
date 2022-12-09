using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblSftWasacoAuditChecklist
{
    public int WacIdpk { get; set; }

    public DateTime? WacDate { get; set; }

    public int? WacSafetyGroupIdfk { get; set; }

    public int? WacInspectionDetailsIdfk { get; set; }

    public int? WacStationIdfk { get; set; }

    public int? WacSectionIdfk { get; set; }

    public int? WacItemIdfk { get; set; }

    public string? WacCoordinatorsComment { get; set; }

    public string? WacManagersComment { get; set; }

    public string? WacSafetySectionsComment { get; set; }

    public string? WacTeamMembers { get; set; }

    public string? WacInspectionTeamLeader { get; set; }

    public string? WacWasacoChairman { get; set; }

    public bool? WacYes { get; set; }

    public bool? WacNo { get; set; }

    public bool? WacRating1 { get; set; }

    public bool? WacRating2 { get; set; }

    public bool? WacRating3 { get; set; }

    public byte? WacOrder { get; set; }

    public bool? WacScoring { get; set; }

    public bool? WacSubmitted { get; set; }

    public int? WacSubmittedByEmpIdfk { get; set; }

    public DateTime? WacSubmittedOn { get; set; }

    public bool? WacAcknowledged { get; set; }

    public int? WacAcknowledgedByEmpIdfk { get; set; }

    public DateTime? WacAcknowledgedOn { get; set; }

    public bool? WacActive { get; set; }

    public string? WacRmks { get; set; }

    public int? WacCreatedBy { get; set; }

    public int? WacEditedBy { get; set; }

    public DateTime? WacCreationDate { get; set; }

    public DateTime? WacEditedDate { get; set; }
}
