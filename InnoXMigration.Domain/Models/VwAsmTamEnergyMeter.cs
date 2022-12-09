using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class VwAsmTamEnergyMeter
{
    public int MtrIdpk { get; set; }

    public string MtrMeterNo { get; set; } = null!;

    public string MtrSerialNo { get; set; } = null!;

    public string MtrShtName { get; set; } = null!;

    public int MtrManufacturerIdfk { get; set; }

    public int MtrAccuracyClassIdfk { get; set; }

    public int MtrSupplyConnectionIdfk { get; set; }

    public int MtrDisplayTypeIdfk { get; set; }

    public DateTime MtrInstallationDate { get; set; }

    public DateTime MtrDateCommissioned { get; set; }

    public DateTime MtrDateDecommissioned { get; set; }

    public DateTime MtrManufactureDate { get; set; }

    public DateTime MtrSupplyDate { get; set; }

    public bool MtrActive { get; set; }

    public string MtrRmks { get; set; } = null!;

    public int FstnIdpk { get; set; }

    public string FstnName { get; set; } = null!;

    public string FstnShtName { get; set; } = null!;

    public int FcustIdpk { get; set; }

    public string FcustName { get; set; } = null!;

    public string FcustShtName { get; set; } = null!;

    public string CustName { get; set; } = null!;

    public string FcustAddress { get; set; } = null!;

    public string FcustSalutation { get; set; } = null!;

    public string FcustContact { get; set; } = null!;

    public string FcustEmail { get; set; } = null!;

    public string FcustMobNo { get; set; } = null!;

    public int FdrIdpk { get; set; }

    public string FdrName { get; set; } = null!;

    public string FdrShtName { get; set; } = null!;

    public int MftIdpk { get; set; }

    public string MftName { get; set; } = null!;

    public string MftShtName { get; set; } = null!;

    public int AclIdpk { get; set; }

    public string AclName { get; set; } = null!;

    public string AclShtName { get; set; } = null!;

    public int DptIdpk { get; set; }

    public string DptName { get; set; } = null!;

    public string DptShtName { get; set; } = null!;

    public int SpcIdpk { get; set; }

    public string SpcName { get; set; } = null!;

    public string SpcShtName { get; set; } = null!;

    public int EstIdpk { get; set; }

    public string EstName { get; set; } = null!;

    public string EstShtName { get; set; } = null!;

    public bool EstFitStatus { get; set; }

    public bool EstActive { get; set; }

    public bool MtrVerified { get; set; }

    public int FmwIdpk { get; set; }

    public string FmwName { get; set; } = null!;

    public string FmwShtName { get; set; } = null!;

    public int EmaIdpk { get; set; }

    public DateTime? EmaStartDate { get; set; }

    public DateTime? EmaEndDate { get; set; }

    public decimal EmaKwhMultiplier { get; set; }

    public decimal EmaKwMultiplier { get; set; }

    public decimal EmaRegLevyRate { get; set; }

    public decimal EmaTransServLevyRate { get; set; }

    public decimal EmaPowInfrasLevyRate { get; set; }

    public decimal EmaAncillaryLevyRate { get; set; }

    public bool EmaTeeingOffMeter { get; set; }

    public bool EmaStationService { get; set; }

    public bool EmaActive { get; set; }

    public int FlocIdpk { get; set; }

    public string FlocName { get; set; } = null!;

    public string FlocShtName { get; set; } = null!;

    public int FareIdpk { get; set; }

    public string FareName { get; set; } = null!;

    public string FareShtName { get; set; } = null!;

    public int GplIdpk { get; set; }

    public string GplName { get; set; } = null!;

    public string GplShtName { get; set; } = null!;

    public int GstIdpk { get; set; }

    public string GstName { get; set; } = null!;

    public string GstShtName { get; set; } = null!;

    public int GcmIdpk { get; set; }

    public string GcmName { get; set; } = null!;

    public string GcmShtName { get; set; } = null!;

    public string FcustTelNo { get; set; } = null!;

    public string FstnTelNo { get; set; } = null!;

    public string FstnPlc { get; set; } = null!;

    public bool MtrStationService { get; set; }

    public decimal EmaCtRatio { get; set; }

    public decimal EmaPtRatio { get; set; }

    public int? MspIdpk { get; set; }

    public string? MspName { get; set; }

    public string? MspShtName { get; set; }

    public bool? MspActive { get; set; }

    public string MtrMobileNo { get; set; } = null!;
}
