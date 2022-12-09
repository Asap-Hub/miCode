using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblBgtMaterialsSchedule
{
    public int MtsIdpk { get; set; }

    public int? MtsBudgetIdfk { get; set; }

    public int? MtsSectionIdfk { get; set; }

    public int? MtsBudgetUnitIdfk { get; set; }

    public decimal? MtsEstimatedQuantity { get; set; }

    public decimal? MtsEstimatedCostUsd { get; set; }

    public decimal? MtsEstimatedCostGhc { get; set; }

    public decimal? MtsQtr1EstimatedQuantity { get; set; }

    public decimal? MtsQtr1ApprovedQuantity { get; set; }

    public decimal? MtsQtr1EstimatedCostGhc { get; set; }

    public decimal? MtsQtr1ApprovedCostGhc { get; set; }

    public decimal? MtsQtr1EstimatedCostUsd { get; set; }

    public decimal? MtsQtr1ApprovedCostUsd { get; set; }

    public decimal? MtsQtr2EstimatedQuantity { get; set; }

    public decimal? MtsQtr2ApprovedQuantity { get; set; }

    public decimal? MtsQtr2EstimatedCostGhc { get; set; }

    public decimal? MtsQtr2ApprovedCostGhc { get; set; }

    public decimal? MtsQtr2EstimatedCostUsd { get; set; }

    public decimal? MtsQtr2ApprovedCostUsd { get; set; }

    public decimal? MtsQtr3EstimatedQuantity { get; set; }

    public decimal? MtsQtr3ApprovedQuantity { get; set; }

    public decimal? MtsQtr3EstimatedCostUsd { get; set; }

    public decimal? MtsQtr3ApprovedCostUsd { get; set; }

    public decimal? MtsQtr3EstimatedCostGhc { get; set; }

    public decimal? MtsQtr3ApprovedCostGhc { get; set; }

    public decimal? MtsQtr4EstimatedQuantity { get; set; }

    public decimal? MtsQtr4ApprovedQuantity { get; set; }

    public decimal? MtsQtr4EstimatedCostGhc { get; set; }

    public decimal? MtsQtr4ApprovedCostGhc { get; set; }

    public decimal? MtsQtr4EstimatedCostUsd { get; set; }

    public string? MtsJustification { get; set; }

    public bool? MtsApproved { get; set; }

    public DateTime? MtsApprovalDate { get; set; }

    public int? MtsApprovedBy { get; set; }

    public string? MtsApprovalRmks { get; set; }

    public string? MtsRmks { get; set; }

    public int? MtsCreatedBy { get; set; }

    public int? MtsEditedBy { get; set; }

    public DateTime? MtsCreationDate { get; set; }

    public DateTime? MtsEditedDate { get; set; }
}
