using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblAsmCompEquipmentDetail
{
    public int EdtIdpk { get; set; }

    public string EdtSerialNo { get; set; } = null!;

    public string EdtTag { get; set; } = null!;

    public int? EdtParentEquipDetailIdfk { get; set; }

    public string? EdtParentSerialNo { get; set; }

    public int? EdtModelIdfk { get; set; }

    public int? EdtSupplierIdfk { get; set; }

    public int? EdtStatusIdfk { get; set; }

    public int? EdtOsidfk { get; set; }

    public int? EdtOsFlavourIdfk { get; set; }

    public int? EdtManufacturerIdfk { get; set; }

    public DateTime? EdtManufactureDate { get; set; }

    public DateTime? EdtSupplyDate { get; set; }

    public bool? EdtAssigned { get; set; }

    public int? EdtOwnerIdfk { get; set; }

    public int? EdtDeptIdfk { get; set; }

    public int? EdtSectionIdfk { get; set; }

    public int? EdtLocIdfk { get; set; }

    public int? EdtCostCenterIdfk { get; set; }

    public int? EdtCostCurrencyIdfk { get; set; }

    public decimal? EdtCost { get; set; }

    public string? EdtCostUnit { get; set; }

    public bool? EdtIsComputer { get; set; }

    public bool? EdtIsLaptop { get; set; }

    public bool? EdtIsDesktop { get; set; }

    public bool? EdtIsTower { get; set; }

    public bool? EdtIsSystemUnit { get; set; }

    public bool? EdtIsWorkstation { get; set; }

    public bool? EdtIsServer { get; set; }

    public bool? EdtIsPeripheral { get; set; }

    public bool? EdtIsScanner { get; set; }

    public bool? EdtIsPrinter { get; set; }

    public bool? EdtIsKeyboard { get; set; }

    public bool? EdtIsMouse { get; set; }

    public bool? EdtIsProjector { get; set; }

    public bool? EdtIsPhone { get; set; }

    public bool? EdtIsTablet { get; set; }

    public bool? EdtIsExternalHdd { get; set; }

    public bool? EdtIsInternalHdd { get; set; }

    public bool? EdtIsSsd { get; set; }

    public bool? EdtMarked { get; set; }

    public bool? EdtActive { get; set; }

    public string? EdtRmks { get; set; }

    public string? EdtCreatedBy { get; set; }

    public int? EdtEditedBy { get; set; }

    public DateTime? EdtCreationDate { get; set; }

    public DateTime? EdtEditedDate { get; set; }
}
