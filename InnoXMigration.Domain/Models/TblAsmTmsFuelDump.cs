using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblAsmTmsFuelDump
{
    public int FdmIdpk { get; set; }

    public int? FdmVehicleDetailIdfk { get; set; }

    public int? FdmVehicleAssignIdfk { get; set; }

    public DateTime? FdmDate { get; set; }

    public int? FdmReceiverEmpIdfk { get; set; }

    public int? FdmAuthoriserEmpIdfk { get; set; }

    public int? FdmServiceProviderIdfk { get; set; }

    public int? FdmServiceStationIdfk { get; set; }

    public int? FdmProductIdfk { get; set; }

    public decimal? FdmQuantity { get; set; }

    public decimal? FdmUnitPrice { get; set; }

    public decimal? FdmBalance { get; set; }

    public string? FdmReceiptNo { get; set; }

    public decimal? FdmCurrentOdometerReading { get; set; }

    public decimal? FdmPreviousOdometerReading { get; set; }

    public int? FdmApprovalSupervisorEmpIdfk { get; set; }

    public int? FdmApprovalManagerEmpIdfk { get; set; }

    public int? FdmApprovalDirectorEmpIdfk { get; set; }

    public int? FdmApprovalTransportMgrEmpIdfk { get; set; }

    public bool? FdmTransportAdminView { get; set; }

    public bool? FdmDeleted { get; set; }

    public DateTime? FdmDateAuthorised { get; set; }

    public bool? FdmAuthorised { get; set; }

    public DateTime? FdmDateAcknowledged { get; set; }

    public bool? FdmAcknowledged { get; set; }

    public bool? FdmLocked { get; set; }

    public int? FdmLockedByEmpIdfk { get; set; }

    public DateTime? FdmLockDate { get; set; }

    public bool? FdmActive { get; set; }

    public string? FdmRmks { get; set; }

    public int? FdmCreatedBy { get; set; }

    public int? FdmCreatorEmpIdfk { get; set; }

    public int? FdmEditedBy { get; set; }

    public DateTime? FdmCreationDate { get; set; }

    public DateTime? FdmEditedDate { get; set; }
}
