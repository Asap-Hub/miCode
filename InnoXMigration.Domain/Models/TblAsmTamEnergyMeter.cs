using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblAsmTamEnergyMeter
{
    public int MtrIdpk { get; set; }

    public string? MtrMeterNo { get; set; }

    public string? MtrSerialNo { get; set; }

    public string? MtrShtName { get; set; }

    public int? MtrManufacturerIdfk { get; set; }

    public int? MtrFirmwareIdfk { get; set; }

    public int? MtrAccuracyClassIdfk { get; set; }

    public int? MtrSupplyConnectionIdfk { get; set; }

    public int? MtrDisplayTypeIdfk { get; set; }

    public int? MtrStatusIdfk { get; set; }

    public int? MtrMobileNetworkIdfk { get; set; }

    public string? MtrMobileNo { get; set; }

    public DateTime? MtrManufactureDate { get; set; }

    public DateTime? MtrSupplyDate { get; set; }

    public DateTime? MtrInstallationDate { get; set; }

    public DateTime? MtrDateCommissioned { get; set; }

    public DateTime? MtrDateDecommissioned { get; set; }

    public int? MtrCurrentAssignmentIdfk { get; set; }

    public bool? MtrStationService { get; set; }

    public bool? MtrVerified { get; set; }

    public bool? MtrActive { get; set; }

    public string? MtrRmks { get; set; }

    public int? MtrCreatedBy { get; set; }

    public int? MtrEditedBy { get; set; }

    public DateTime? MtrCreationDate { get; set; }

    public DateTime? MtrEditedDate { get; set; }
}
