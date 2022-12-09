using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblBgtToolsAndEquipment
{
    public int TaeIdpk { get; set; }

    public int? TaeBudgetIdfk { get; set; }

    public int? TaeSectionIdfk { get; set; }

    public int? TaeBudgetUnitIdfk { get; set; }

    public decimal? TaeEstimatedQuantity { get; set; }

    public decimal? TaeEstimatedCostUsd { get; set; }

    public decimal? TaeEstimatedCostGhc { get; set; }

    public decimal? TaeQtr1EstimatedQuantity { get; set; }

    public decimal? TaeQtr1ApprovedQuantity { get; set; }

    public decimal? TaeQtr1EstimatedCostGhc { get; set; }

    public decimal? TaeQtr1ApprovedCostGhc { get; set; }

    public decimal? TaeQtr1EstimatedCostUsd { get; set; }

    public decimal? TaeQtr1ApprovedCostUsd { get; set; }

    public decimal? TaeQtr2EstimatedQuantity { get; set; }

    public decimal? TaeQtr2ApprovedQuantity { get; set; }

    public decimal? TaeQtr2EstimatedCostGhc { get; set; }

    public decimal? TaeQtr2ApprovedCostGhc { get; set; }

    public decimal? TaeQtr2EstimatedCostUsd { get; set; }

    public decimal? TaeQtr2ApprovedCostUsd { get; set; }

    public decimal? TaeQtr3EstimatedQuantity { get; set; }

    public decimal? TaeQtr3ApprovedQuantity { get; set; }

    public decimal? TaeQtr3EstimatedCostUsd { get; set; }

    public decimal? TaeQtr3ApprovedCostUsd { get; set; }

    public decimal? TaeQtr3EstimatedCostGhc { get; set; }

    public decimal? TaeQtr3ApprovedCostGhc { get; set; }

    public decimal? TaeQtr4EstimatedQuantity { get; set; }

    public decimal? TaeQtr4ApprovedQuantity { get; set; }

    public decimal? TaeQtr4EstimatedCostGhc { get; set; }

    public decimal? TaeQtr4ApprovedCostGhc { get; set; }

    public decimal? TaeQtr4EstimatedCostUsd { get; set; }

    public string? TaeJustification { get; set; }

    public bool? TaeApproved { get; set; }

    public DateTime? TaeApprovalDate { get; set; }

    public int? TaeApprovedBy { get; set; }

    public string? TaeApprovalRmks { get; set; }

    public string? TaeRmks { get; set; }

    public int? TaeCreatedBy { get; set; }

    public int? TaeEditedBy { get; set; }

    public DateTime? TaeCreationDate { get; set; }

    public DateTime? TaeEditedDate { get; set; }
}
