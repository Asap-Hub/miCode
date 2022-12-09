using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class VwBgtOfficeEquipmentRequirementDetail
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

    public bool? OrdActive { get; set; }

    public string? OrdRmks { get; set; }

    public int? OrdCreatedBy { get; set; }

    public int? OrdEditedBy { get; set; }

    public DateTime? OrdCreationDate { get; set; }

    public DateTime? OrdEditedDate { get; set; }

    public int BgtIdpk { get; set; }

    public string? BgtName { get; set; }

    public string? BgtShtName { get; set; }

    public DateTime? BgtStartDate { get; set; }

    public DateTime? BgtEndDate { get; set; }

    public bool? BgtOpened { get; set; }

    public int OetIdpk { get; set; }

    public string? OetName { get; set; }

    public string? OetShtName { get; set; }

    public bool? OetActive { get; set; }

    public int DptIdpk { get; set; }

    public string? DptName { get; set; }

    public string? DptShtName { get; set; }

    public string? DptCode { get; set; }

    public int SxnIdpk { get; set; }

    public string SxnName { get; set; } = null!;

    public string SxnShtName { get; set; } = null!;

    public string? SxnCode { get; set; }

    public int? UntIdpk { get; set; }

    public string? UntName { get; set; }

    public string? UntShtName { get; set; }

    public string OrdJustification { get; set; } = null!;

    public decimal? OrdTotalCostSubmitted { get; set; }

    public decimal? OrdTotalCostApproved { get; set; }

    public int RtpIdpk { get; set; }

    public string? RtpName { get; set; }

    public string? RtpShtName { get; set; }

    public int CurIdpk { get; set; }

    public string? CurName { get; set; }

    public DateTime? CurDate { get; set; }

    public string? CurShtName { get; set; }

    public string? CurSymbol { get; set; }

    public bool? CurForeign { get; set; }

    public byte? CurOrder { get; set; }
}
