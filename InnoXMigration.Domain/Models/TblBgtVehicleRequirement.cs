using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblBgtVehicleRequirement
{
    public int VrqIdpk { get; set; }

    public string? VrqBudgetIdfk { get; set; }

    public string? VrqSectionIdfk { get; set; }

    public string? VrqMotorBike { get; set; }

    public string? VrqSaloon1P8l { get; set; }

    public string? VrqSaloon2P4l { get; set; }

    public string? VrqPickuDc4x4 { get; set; }

    public string? VrqPickuDc4x4Rugged { get; set; }

    public string? VrqStationWagonMgmtTeam { get; set; }

    public string? VrqStationWagonElecTeam { get; set; }

    public string? VrqStationWagonLinesTeam { get; set; }

    public string? VrqTruckDc2tons { get; set; }

    public string? VrqTruck3To7Tons { get; set; }

    public string? VrqMiniBus { get; set; }

    public string? VrqMidiBus { get; set; }

    public string? VrqMaxiBus { get; set; }

    public bool? VrqAerialBucket7T { get; set; }

    public string? VrqTruckSelfLoading { get; set; }

    public string? VrqFireTender { get; set; }

    public string? VrqTotalEstimatedCostUsd { get; set; }

    public string? VrqApprovedCostUsd { get; set; }

    public string? VrgApprovedCostGhc { get; set; }

    public int? VrqApprovalDate { get; set; }

    public int? VrqApprovedBy { get; set; }

    public string? VrqApprovalRmks { get; set; }

    public string? VrqRmks { get; set; }

    public int? VrqCreatedBy { get; set; }

    public int? VrqEditedBy { get; set; }

    public DateTime? VrqCreationDate { get; set; }

    public DateTime? VrqEditedDate { get; set; }
}
