using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblBgtFurnitureAndEquipment
{
    public int FaeIdpk { get; set; }

    public int? FaeBudgetIdfk { get; set; }

    public int? FaeSectionIdfk { get; set; }

    public int? FaeRoomIdfk { get; set; }

    public decimal? FaeUnitPriceGhc { get; set; }

    public decimal? FaeTotalQuantity { get; set; }

    public decimal? FaeTotalGhc { get; set; }

    public bool? FaeApproved { get; set; }

    public int? FaeApprovalDate { get; set; }

    public int? FaeApprovedBy { get; set; }

    public string? FaeApprovalRmks { get; set; }

    public string? FaeRmks { get; set; }

    public int? FaeCreatedBy { get; set; }

    public int? FaeEditedBy { get; set; }

    public DateTime? FaeCreationDate { get; set; }

    public DateTime? FaeEditedDate { get; set; }
}
