using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblAsmTmsFuelManagement
{
    public int FmgIdpk { get; set; }

    public int? FmgVehicleDetailIdfk { get; set; }

    public DateTime? FmgDate { get; set; }

    public DateTime? FmgDateDispensed { get; set; }

    public DateTime? FmgDateAcknowledged { get; set; }

    public DateTime? FmgDateAuthorised { get; set; }

    public int? FmgDriverIdfk { get; set; }

    public int? FmgAuthoriserEmpIdfk { get; set; }

    public int? FmgDispenserEmpIdfk { get; set; }

    public int? FmgServiceProviderIdfk { get; set; }

    public int? FmgServiceStationIdfk { get; set; }

    public int? FmgProductIdfk { get; set; }

    public int? FmgPurchaseModeIdfk { get; set; }

    public int? FmgCardIdfk { get; set; }

    public int? FmgFuelUnitIdfk { get; set; }

    public decimal? FmgAmount { get; set; }

    public decimal? FmgBalance { get; set; }

    public decimal? FmgQuantityRequested { get; set; }

    public decimal? FmgQuantityAuthorised { get; set; }

    public decimal? FmgQuantityDispensed { get; set; }

    public string? FmgReceiptNo { get; set; }

    public decimal? FmgCurrentOdometerReading { get; set; }

    public decimal? FmgPreviousOdometerReading { get; set; }

    public int? FmgApprovalSupervisorEmpIdfk { get; set; }

    public int? FmgApprovalManagerEmpIdfk { get; set; }

    public int? FmgApprovalDirectorEmpIdfk { get; set; }

    public int? FmgApprovalTransportMgrEmpIdfk { get; set; }

    public int? FmgVehicleAssignmentIdfk { get; set; }

    public int? FmgDebitDeptIdfk { get; set; }

    public int? FmgDebitSectionIdfk { get; set; }

    public int? FmgCostCenterIdfk { get; set; }

    public bool? FmgTransportAdminView { get; set; }

    public bool? FmgDeleted { get; set; }

    public bool? FmgVerified { get; set; }

    public bool? FmgAuthorised { get; set; }

    public bool? FmgCancelled { get; set; }

    public bool? FmgAcknowledged { get; set; }

    public bool? FmgActive { get; set; }

    public string? FmgDispenserRmks { get; set; }

    public string? FmgRmks { get; set; }

    public string? FmgAuthoriserRmks { get; set; }

    public string? FmgDeleteRmks { get; set; }

    public bool? FmgLocked { get; set; }

    public int? FmgLockedByEmpIdfk { get; set; }

    public DateTime? FmgLockDate { get; set; }

    public int? FmgVerifiedByEmpIdfk { get; set; }

    public int? FmgCreatedBy { get; set; }

    public int? FmgEditedBy { get; set; }

    public DateTime? FmgCreationDate { get; set; }

    public DateTime? FmgVerifiedOn { get; set; }

    public DateTime? FmgEditedDate { get; set; }
}
