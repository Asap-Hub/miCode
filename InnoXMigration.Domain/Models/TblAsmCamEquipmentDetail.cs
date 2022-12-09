using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblAsmCamEquipmentDetail
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

    public bool? EdtComputer { get; set; }

    public bool? EdtLaptop { get; set; }

    public bool? EdtDesktop { get; set; }

    public bool? EdtTower { get; set; }

    public bool? EdtSystemUnit { get; set; }

    public bool? EdtWorkstation { get; set; }

    public bool? EdtServer { get; set; }

    public bool? EdtPeripheral { get; set; }

    public bool? EdtScanner { get; set; }

    public bool? EdtPrinter { get; set; }

    public bool? EdtMonitor { get; set; }

    public bool? EdtKeyboard { get; set; }

    public bool? EdtMouse { get; set; }

    public bool? EdtProjector { get; set; }

    public bool? EdtPhone { get; set; }

    public bool? EdtTablet { get; set; }

    public bool? EdtExternalHdd { get; set; }

    public bool? EdtInternalHdd { get; set; }

    public bool? EdtSsd { get; set; }

    public bool? EdtUps { get; set; }

    public bool? EdtPhotocopier { get; set; }

    public bool? EdtSwitch { get; set; }

    public bool? EdtRouter { get; set; }

    public bool? EdtShredder { get; set; }

    public bool? EdtFaxMachine { get; set; }

    public bool? EdtMoneyCountingMachine { get; set; }

    public bool? EdtDetailsVerified { get; set; }

    public bool? EdtAssignmentVerified { get; set; }

    public bool? EdtMarked { get; set; }

    public bool? EdtActive { get; set; }

    public string? EdtRmks { get; set; }

    public string? EdtCreatedBy { get; set; }

    public int? EdtEditedBy { get; set; }

    public DateTime? EdtCreationDate { get; set; }

    public DateTime? EdtEditedDate { get; set; }
}
