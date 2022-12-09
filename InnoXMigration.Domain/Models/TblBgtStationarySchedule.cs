using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblBgtStationarySchedule
{
    public int StsIdpk { get; set; }

    public int? StsBudgetIdfk { get; set; }

    public int? StsSectionIdfk { get; set; }

    public int? StsBudgetUnitIdfk { get; set; }

    public int? StsItemIdfk { get; set; }

    public decimal? StsEstimatedUnitPrice { get; set; }

    public string? StsApprovedUnitPrice { get; set; }

    public decimal? StsTotalQuantity { get; set; }

    public string? StsQuantityPerUnit { get; set; }

    public string? StsJustification { get; set; }

    public bool? StsApproved { get; set; }

    public DateTime? StsApprovalDate { get; set; }

    public int? StsApprovedBy { get; set; }

    public string? StsApprovalRmks { get; set; }

    public string? StsRmks { get; set; }

    public int? StsCreatedBy { get; set; }

    public int? StsEditedBy { get; set; }

    public DateTime? StsCreationDate { get; set; }

    public DateTime? StsEditedDate { get; set; }
}
