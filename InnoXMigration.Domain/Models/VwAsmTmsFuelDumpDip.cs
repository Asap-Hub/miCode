using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class VwAsmTmsFuelDumpDip
{
    public int FddIdpk { get; set; }

    public int? FddServiceStationIdfk { get; set; }

    public DateTime? FddDate { get; set; }

    public decimal FddTankCapacity { get; set; }

    public decimal FddOpeningBalance { get; set; }

    public decimal FddReceipt { get; set; }

    public decimal FddIssue { get; set; }

    public decimal FddClosingBalance { get; set; }

    public decimal FddOpeningMeterReading { get; set; }

    public decimal FddClosingMeterReading { get; set; }

    public decimal FddOpeningDipBalance { get; set; }

    public bool FddActive { get; set; }

    public string FddRmks { get; set; } = null!;

    public int SstIdpk { get; set; }

    public string? SstName { get; set; }

    public string? SstShtName { get; set; }

    public string? SstStationNo { get; set; }

    public int? SstServiceProviderIdfk { get; set; }

    public int? SstTownIdfk { get; set; }

    public bool? SstActive { get; set; }

    public string? SstRmks { get; set; }

    public string? SstCreatedBy { get; set; }

    public int? SstEditedBy { get; set; }

    public int TwnIdpk { get; set; }

    public string? TwnName { get; set; }

    public string? TwnShtName { get; set; }

    public int DstIdpk { get; set; }

    public string DstName { get; set; } = null!;

    public string DstShtName { get; set; } = null!;

    public int? RgnIdpk { get; set; }

    public string? RgnName { get; set; }

    public string? RgnShtName { get; set; }

    public int SpdIdpk { get; set; }

    public string? SpdName { get; set; }

    public string? SpdShtName { get; set; }

    public string? SpdMainContact { get; set; }

    public string? SpdMobNos { get; set; }

    public string? SpdEmail { get; set; }

    public string? SpdTelNos { get; set; }

    public string? SpdPostalAddress { get; set; }

    public string? SpdResidentialAddress { get; set; }

    public bool? SpdActive { get; set; }

    public string? SstMainContacts { get; set; }

    public string? SstTelNos { get; set; }

    public string? SsteMails { get; set; }

    public bool? SpdFuelDump { get; set; }

    public bool? SstFuelDump { get; set; }

    public int? FddProductIdfk { get; set; }

    public int? PrdIdpk { get; set; }

    public string? PrdName { get; set; }

    public string? PrdShtName { get; set; }

    public bool? PrdActive { get; set; }
}
