using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblBgtVehicleRequirementDetail
{
    public int VrdIdpk { get; set; }

    public int? VrdBudgetIdfk { get; set; }

    public int? VrdDeptIdfk { get; set; }

    public int? VrdSectionIdfk { get; set; }

    public int? VrdUnitIdfk { get; set; }

    public int? VrdVehicleTypeIdfk { get; set; }

    public decimal? VrdQuantity { get; set; }

    public decimal? VrdUnitCostSubmitted { get; set; }

    public decimal? VrdUnitCostApproved { get; set; }

    public decimal? VrdTotalCostSubmitted { get; set; }

    public decimal? VrdTotalCostApproved { get; set; }

    public string? VrdJustification { get; set; }

    public int? VrdRequestTypeIdfk { get; set; }

    public int? VrdSubmittedCurrencyIdfk { get; set; }

    public bool? VrdActive { get; set; }

    public string? VrdRmks { get; set; }

    public int? VrdCreatedBy { get; set; }

    public int? VrdEditedBy { get; set; }

    public DateTime? VrdCreationDate { get; set; }

    public DateTime? VrdEditedDate { get; set; }
}
