using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblAsmTamTransformerDetail
{
    public int TfdIdpk { get; set; }

    public string? TfdSerialNo { get; set; }

    public string? TfdTransformerId { get; set; }

    public string? TfdStationIdfk { get; set; }

    public int? TfdLocationIdfk { get; set; }

    public string? TfdStandard { get; set; }

    public string? TfdRatedVoltageI { get; set; }

    public string? TfdRatedVoltageIi { get; set; }

    public string? TfdRatedVoltageIii { get; set; }

    public string? TfdRatedPowerI { get; set; }

    public string? TfdRatedPowerIi { get; set; }

    public string? TfdRatedPowerIii { get; set; }

    public string? TfdRatedOutput { get; set; }

    public string? TfdConnectionSymbol { get; set; }

    public string? TfdCoolingType { get; set; }

    public string? TfdTapChangerType { get; set; }

    public string? TfdTappedWinding { get; set; }

    public string? TfdTapChangerRange { get; set; }

    public string? TfdTapChangerStep { get; set; }

    public string? TfdNominalTap { get; set; }

    public string? TfdPercentImpedanceAt75Deg { get; set; }

    public string? TfdZhAt100MvabaseAt75Deg { get; set; }

    public string? TfdZxAt100MvabaseAt75Deg { get; set; }

    public string? TfdZyAt100MvabaseAt75Deg { get; set; }

    public string? TfdResistanceAt100MvabaseAt75Deg { get; set; }

    public DateTime? TfdCommissionDate { get; set; }

    public DateTime? TfdDecommissionDate { get; set; }

    public DateTime? TfdManufactureDate { get; set; }

    public DateTime? TfdInstallationStartDate { get; set; }

    public DateTime? TfdSupplyDate { get; set; }

    public int? TfdStatusIdfk { get; set; }

    public string? TfdManufacturerIdfk { get; set; }

    public int? TfdSupplierIdfk { get; set; }

    public string? TfdBasicImpulseLevelHvLineKv { get; set; }

    public string? TfdBasicImpulseLevelHvNeutralKv { get; set; }

    public string? TfdBasicImpulseLevelHvMvKv { get; set; }

    public string? TfdBasicImpulseLevelHvLvKv { get; set; }

    public string? TfdAngles { get; set; }

    public string? TfdManufactureStandard { get; set; }

    public string? TfdOilTemperatureRiseDeg { get; set; }

    public string? TfdWindingTemperatureRiseDeg { get; set; }

    public string? TfdNamePlateData { get; set; }

    public bool? TfdAssigned { get; set; }

    public bool? TfdVerified { get; set; }

    public bool? TfdShowInStationReadings { get; set; }

    public bool? TfdActive { get; set; }

    public string? TfdRmks { get; set; }

    public int? TfdCreatedBy { get; set; }

    public int? TfdEditedBy { get; set; }

    public DateTime? TfdCreationDate { get; set; }

    public DateTime? TfdEditedDate { get; set; }
}
