using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class VwAsmTamEnergyMeterAssignmentsx
{
    public int EmaIdpk { get; set; }

    public DateTime? EmaStartDate { get; set; }

    public DateTime? EmaEndDate { get; set; }

    public int? EmaStationIdfk { get; set; }

    public int? EmaLocationIdfk { get; set; }

    public int? EmaCustomerIdfk { get; set; }

    public int? EmaFeederIdfk { get; set; }

    public int? EmaMeterIdfk { get; set; }

    public int? EmaReportTypeIdfk { get; set; }

    public int? EmaCustomerTypeIdfk { get; set; }

    public int? EmaTscCurrencyIdfk { get; set; }

    public int? EmaRegLevyCurrencyIdfk { get; set; }

    public decimal EmaKwhMultiplier { get; set; }

    public decimal EmaKwMultiplier { get; set; }

    public decimal EmaRegLevyRate { get; set; }

    public decimal EmaTransServLevyRate { get; set; }

    public decimal EmaPowInfrasLevyRate { get; set; }

    public decimal EmaAncillaryLevyRate { get; set; }

    public int EmaGenerationPlantIdfk { get; set; }

    public int EmaPlantLineNoIdfk { get; set; }

    public bool EmaAssigned { get; set; }

    public bool EmaTeeingOffMeter { get; set; }

    public bool EmaStationService { get; set; }

    public bool EmaActive { get; set; }

    public string EmaRmks { get; set; } = null!;

    public int? EmaCreatedBy { get; set; }

    public int FstnIdpk { get; set; }

    public string FstnName { get; set; } = null!;

    public string FstnShtName { get; set; } = null!;

    public int FlocIdpk { get; set; }

    public string FlocName { get; set; } = null!;

    public string FlocShtName { get; set; } = null!;

    public int FareIdpk { get; set; }

    public string FareName { get; set; } = null!;

    public string FareShtName { get; set; } = null!;

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

    public int FrtpIdpk { get; set; }

    public string FrtpName { get; set; } = null!;

    public bool FrtpPfc { get; set; }

    public bool FrtpPrl { get; set; }

    public bool FrtpPtsr { get; set; }

    public bool FrtpActive { get; set; }

    public int FctpIdpk { get; set; }

    public string FctpName { get; set; } = null!;

    public string FctpShtName { get; set; } = null!;

    public bool FctpActive { get; set; }

    public int TscCurIdpk { get; set; }

    public string TscCurName { get; set; } = null!;

    public string TscCurShtName { get; set; } = null!;

    public string TscCurSymbol { get; set; } = null!;

    public bool TscCurForeign { get; set; }

    public int RegLevyCurIdpk { get; set; }

    public string RegLevyCurName { get; set; } = null!;

    public string RegLevyCurShtName { get; set; } = null!;

    public string RegLevyCurSymbol { get; set; } = null!;

    public bool RegLevyCurForeign { get; set; }

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

    public decimal EmaCtRatio { get; set; }

    public decimal EmaPtRatio { get; set; }

    public bool EmaCheckMeter { get; set; }

    public bool EmaBulkSupplyPoint { get; set; }
}
