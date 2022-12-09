using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblBgtTransportSchedule
{
    public int TrsIdpk { get; set; }

    public int? TrsBudgetIdfk { get; set; }

    public int? TrsSectionIdfk { get; set; }

    public int? TrsBudgetUnitIdfk { get; set; }

    public string? TrsNoOfVehicle { get; set; }

    public int? TrsVehicleTypeIdfk { get; set; }

    public string? TrsRegNo { get; set; }

    public int? TrsLocationIdfk { get; set; }

    public decimal? TrsFuelUsageLpa { get; set; }

    public decimal? TrsLubricantUsageLpa { get; set; }

    public decimal? TrsMaintenanceCostGhcpa { get; set; }

    public decimal? TrsOtherCostGhcpa { get; set; }

    public decimal? TrsTotalCostGhcpa { get; set; }

    public string? TrsJustification { get; set; }

    public bool? TrsApproved { get; set; }

    public DateTime? TrsApprovalDate { get; set; }

    public int? TrsApprovedBy { get; set; }

    public string? TrsApprovalRmks { get; set; }

    public string? TrsRmks { get; set; }

    public int? TrsCreatedBy { get; set; }

    public int? TrsEditedBy { get; set; }

    public DateTime? TrsCreationDate { get; set; }

    public DateTime? TrsEditedDate { get; set; }
}
