using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class VwAsmTamTransformerDetail
{
    public int TfdIdpk { get; set; }

    public string? TfdSerialNo { get; set; }

    public string? TfdTransformerId { get; set; }

    public string? TfdStationIdfk { get; set; }

    public int? TfdStatusIdfk { get; set; }

    public string? TfdTapChangerRange { get; set; }

    public string? TfdPercentImpedanceAt75Deg { get; set; }

    public string TfdNominalTap { get; set; } = null!;

    public string TfdRatedOutput { get; set; } = null!;

    public string TfdRatedVoltageI { get; set; } = null!;

    public string TfdRatedVoltageIi { get; set; } = null!;

    public string TfdRatedVoltageIii { get; set; } = null!;

    public string TfdRatedPowerI { get; set; } = null!;

    public string TfdRatedPowerIi { get; set; } = null!;

    public string TfdRatedPowerIii { get; set; } = null!;

    public string TfdZhAt100MvabaseAt75Deg { get; set; } = null!;

    public string TfdZxAt100MvabaseAt75Deg { get; set; } = null!;

    public string TfdZyAt100MvabaseAt75Deg { get; set; } = null!;

    public string TfdResistanceAt100MvabaseAt75Deg { get; set; } = null!;

    public string? TfdManufacturerIdfk { get; set; }

    public int? TfdSupplierIdfk { get; set; }

    public DateTime TfdCommissionDate { get; set; }

    public DateTime TfdDecommissionDate { get; set; }

    public DateTime TfdManufactureDate { get; set; }

    public decimal? ManufactureAge { get; set; }

    public DateTime TfdInstallationStartDate { get; set; }

    public decimal? InstallationAge { get; set; }

    public DateTime TfdSupplyDate { get; set; }

    public decimal? SupplyAge { get; set; }

    public bool TfdAssigned { get; set; }

    public bool TfdActive { get; set; }

    public string TfdRmks { get; set; } = null!;

    public string TfdStandard { get; set; } = null!;

    public string TfdCoolingType { get; set; } = null!;

    public string TfdTapChangerType { get; set; } = null!;

    public string TfdConnectionSymbol { get; set; } = null!;

    public int? StnIdpk { get; set; }

    public string? StnName { get; set; }

    public string? StnShtName { get; set; }

    public string? StnCode { get; set; }

    public string? StnContact { get; set; }

    public string? StnTelNo { get; set; }

    public string? StnPlc { get; set; }

    public string? StnEmail { get; set; }

    public string TfdTappedWinding { get; set; } = null!;

    public int? EstIdpk { get; set; }

    public string? EstName { get; set; }

    public string? EstShtName { get; set; }

    public bool? EstFitStatus { get; set; }

    public bool? EstActive { get; set; }

    public string? EstRmks { get; set; }

    public int MftIdpk { get; set; }

    public string? MftName { get; set; }

    public string? MftShtName { get; set; }

    public bool? MftActive { get; set; }

    public string? MftRmks { get; set; }

    public int? SplIdpk { get; set; }

    public string? SplName { get; set; }

    public string? SplShtName { get; set; }

    public bool? SplActive { get; set; }

    public string? SplRmks { get; set; }

    public string TfdTapChangerStep { get; set; } = null!;

    public string TfdBasicImpulseLevelHvLineKv { get; set; } = null!;

    public string TfdBasicImpulseLevelHvNeutralKv { get; set; } = null!;

    public string TfdBasicImpulseLevelHvMvKv { get; set; } = null!;

    public string TfdBasicImpulseLevelHvLvKv { get; set; } = null!;

    public string TfdAngles { get; set; } = null!;

    public string TfdManufactureStandard { get; set; } = null!;

    public string TfdOilTemperatureRiseDeg { get; set; } = null!;

    public string TfdWindingTemperatureRiseDeg { get; set; } = null!;

    public string TfdNamePlateData { get; set; } = null!;

    public int? TalIdpk { get; set; }

    public string? TalName { get; set; }

    public string? TalShtName { get; set; }

    public bool? TalActive { get; set; }

    public int? TfdLocationIdfk { get; set; }

    public bool TfdVerified { get; set; }

    public bool TfdShowInStationReadings { get; set; }
}
