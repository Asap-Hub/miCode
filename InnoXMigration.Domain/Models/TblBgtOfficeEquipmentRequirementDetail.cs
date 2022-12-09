using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblBgtOfficeEquipmentRequirementDetail
{
    public int OrdIdpk { get; set; }

    public int? OrdBudgetIdfk { get; set; }

    public int? OrdDeptIdfk { get; set; }

    public int? OrdSectionIdfk { get; set; }

    public int? OrdUnitIdfk { get; set; }

    public int? OrdEquipmentTypeIdfk { get; set; }

    public decimal? OrdQuantity { get; set; }

    public decimal? OrdUnitCostSubmitted { get; set; }

    public decimal? OrdUnitCostApproved { get; set; }

    public decimal? OrdTotalCostSubmitted { get; set; }

    public decimal? OrdTotalCostApproved { get; set; }

    public string? OrdJustification { get; set; }

    public int? OrdRequestTypeIdfk { get; set; }

    public int? OrdSubmittedCurrencyIdfk { get; set; }

    public bool? OrdActive { get; set; }

    public string? OrdRmks { get; set; }

    public int? OrdCreatedBy { get; set; }

    public int? OrdEditedBy { get; set; }

    public DateTime? OrdCreationDate { get; set; }

    public DateTime? OrdEditedDate { get; set; }
}
