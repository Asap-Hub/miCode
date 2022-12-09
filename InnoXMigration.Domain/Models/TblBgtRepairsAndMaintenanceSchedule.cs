using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblBgtRepairsAndMaintenanceSchedule
{
    public int RmsIdpk { get; set; }

    public int? RmsBudgetIdfk { get; set; }

    public int? RmsSectionIdfk { get; set; }

    public int? RmsBudgetUnitIdfk { get; set; }

    public decimal? RmsEstimatedQuantity { get; set; }

    public decimal? RmsEstimatedCostUsd { get; set; }

    public decimal? RmsEstimatedCostGhc { get; set; }

    public decimal? RmsQtr1EstimatedQuantity { get; set; }

    public decimal? RmsQtr1ApprovedQuantity { get; set; }

    public decimal? RmsQtr1EstimatedCostGhc { get; set; }

    public decimal? RmsQtr1ApprovedCostGhc { get; set; }

    public decimal? RmsQtr1EstimatedCostUsd { get; set; }

    public decimal? RmsQtr1ApprovedCostUsd { get; set; }

    public decimal? RmsQtr2EstimatedQuantity { get; set; }

    public decimal? RmsQtr2ApprovedQuantity { get; set; }

    public decimal? RmsQtr2EstimatedCostGhc { get; set; }

    public decimal? RmsQtr2ApprovedCostGhc { get; set; }

    public decimal? RmsQtr2EstimatedCostUsd { get; set; }

    public decimal? RmsQtr2ApprovedCostUsd { get; set; }

    public decimal? RmsQtr3EstimatedQuantity { get; set; }

    public decimal? RmsQtr3ApprovedQuantity { get; set; }

    public decimal? RmsQtr3EstimatedCostUsd { get; set; }

    public decimal? RmsQtr3ApprovedCostUsd { get; set; }

    public decimal? RmsQtr3EstimatedCostGhc { get; set; }

    public decimal? RmsQtr3ApprovedCostGhc { get; set; }

    public decimal? RmsQtr4EstimatedQuantity { get; set; }

    public decimal? RmsQtr4ApprovedQuantity { get; set; }

    public decimal? RmsQtr4EstimatedCostGhc { get; set; }

    public decimal? RmsQtr4ApprovedCostGhc { get; set; }

    public decimal? RmsQtr4EstimatedCostUsd { get; set; }

    public string? RmsJustification { get; set; }

    public bool? RmsApproved { get; set; }

    public DateTime? RmsApprovalDate { get; set; }

    public int? RmsApprovedBy { get; set; }

    public string? RmsApprovalRmks { get; set; }

    public string? RmsRmks { get; set; }

    public int? RmsCreatedBy { get; set; }

    public int? RmsEditedBy { get; set; }

    public DateTime? RmsCreationDate { get; set; }

    public DateTime? RmsEditedDate { get; set; }
}
