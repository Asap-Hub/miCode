using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblHrEmpOrgHistory
{
    public int EohIdpk { get; set; }

    public int? EohOrgIdfk { get; set; }

    public int? EohBranchIdfk { get; set; }

    public int? EohDeptIdfk { get; set; }

    public int? EohSectionIdfk { get; set; }

    public int? EohUnitIdfk { get; set; }

    public int? EohAreaIdfk { get; set; }

    public int? EohLocationIdfk { get; set; }

    public int? EohCostCenterIdfk { get; set; }

    public int? EohRoomIdfk { get; set; }

    public string? EohOrgUnit { get; set; }

    public string? EohOrgUnitType { get; set; }

    public int? EohSupervisorEmpIdfk { get; set; }

    public int? EohManagerEmpIdfk { get; set; }

    public int? EohDirectorEmpIdfk { get; set; }

    public bool? EohActive { get; set; }

    public string? EohRmks { get; set; }

    public int? EohCreatedBy { get; set; }

    public int? EohEditedBy { get; set; }

    public DateTime? EohCreationDate { get; set; }

    public DateTime? EohEditedDate { get; set; }
}
