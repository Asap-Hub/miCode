using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class VwSftWasacoAuditChecklist
{
    public int WacIdpk { get; set; }

    public DateTime? WacDate { get; set; }

    public int? WacSafetyGroupIdfk { get; set; }

    public int? WacInspectionDetailsIdfk { get; set; }

    public int? WacStationIdfk { get; set; }

    public int? WacSectionIdfk { get; set; }

    public int? WacItemIdfk { get; set; }

    public string WacCoordinatorsComment { get; set; } = null!;

    public string WacSafetySectionsComment { get; set; } = null!;

    public string WacManagersComment { get; set; } = null!;

    public string WacTeamMembers { get; set; } = null!;

    public bool WacYes { get; set; }

    public bool WacNo { get; set; }

    public bool WacScoring { get; set; }

    public bool WacSubmitted { get; set; }

    public int? WacSubmittedByEmpIdfk { get; set; }

    public DateTime? WacSubmittedOn { get; set; }

    public int? WacAcknowledgedByEmpIdfk { get; set; }

    public DateTime? WacAcknowledgedOn { get; set; }

    public bool WacActive { get; set; }

    public string WacRmks { get; set; } = null!;

    public int SgpIdpk { get; set; }

    public string SgpName { get; set; } = null!;

    public string SgpShtName { get; set; } = null!;

    public int WstIdpk { get; set; }

    public string WstName { get; set; } = null!;

    public string WstShtName { get; set; } = null!;

    public int IsnIdpk { get; set; }

    public string IsnName { get; set; } = null!;

    public string IsnShtName { get; set; } = null!;

    public bool WstActive { get; set; }

    public int IitIdpk { get; set; }

    public string IitName { get; set; } = null!;

    public string IitShtName { get; set; } = null!;

    public bool IitActive { get; set; }

    public int WidIdpk { get; set; }

    public string WidName { get; set; } = null!;

    public DateTime? WidStartDate { get; set; }

    public DateTime? WidEndDate { get; set; }

    public bool WidScoring { get; set; }

    public string WacInspectionTeamLeader { get; set; } = null!;

    public string WacWasacoChairman { get; set; } = null!;

    public bool WacAcknowledged { get; set; }

    public bool IsnActive { get; set; }

    public bool WacRating1 { get; set; }

    public bool WacRating2 { get; set; }

    public bool WacRating3 { get; set; }

    public byte WacOrder { get; set; }
}
