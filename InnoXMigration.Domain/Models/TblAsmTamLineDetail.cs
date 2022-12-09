using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblAsmTamLineDetail
{
    public int LdtIdpk { get; set; }

    public string? LdtName { get; set; }

    public string LdtNomenclature { get; set; } = null!;

    public int LdtSourceStationIdfk { get; set; }

    public int? LdtDestinationStationIdfk { get; set; }

    public int? LdtLocationIdfk { get; set; }

    public decimal? LdtLength { get; set; }

    public int? LdtLenghtUnitIdfk { get; set; }

    public DateTime? LdtConstructionDate { get; set; }

    public DateTime? LdtCommissionDate { get; set; }

    public DateTime? LdtDecommissionDate { get; set; }

    public decimal? LdtOperatingVoltage { get; set; }

    public int? LdtConductorTypeIdfk { get; set; }

    public int? LdtConductorCodeNameIdfk { get; set; }

    public int? LdtManufacturerIdfk { get; set; }

    public decimal? LdtConductorCrossSectionalArea { get; set; }

    public decimal? LdtPositiveSeqResistancePerKm { get; set; }

    public int? LdtInsulatorTypeIdfk { get; set; }

    public int? LdtConductorTowerConfigurationIdfk { get; set; }

    public int? LdtTowerDesignTypeIdfk { get; set; }

    public decimal? LdtPositiveSeqReactancePerKm { get; set; }

    public double? LdtSusceptancePerKm { get; set; }

    public decimal? LdtResistanceOn100MvaBase { get; set; }

    public decimal? LdtReactanceOn100MvaBase { get; set; }

    public double? LdtSusceptanceOn100MvaBase { get; set; }

    public decimal? LdtZeroSeqResistance { get; set; }

    public decimal? LdtZeroSeqReactance { get; set; }

    public double? LdtZeroSeqSusceptance { get; set; }

    public decimal? LdtZeroSeqResistanceOn100MvaBase { get; set; }

    public decimal? LdtZeroSeqReactanceOn100MvaBase { get; set; }

    public double? LdtZeroSeqSusceptanceOn100MvaBase { get; set; }

    public decimal? LdtThermalLimit { get; set; }

    public decimal? LdtSurgeImpedanceLoading { get; set; }

    public DateTime? LdtManufactureDate { get; set; }

    public DateTime? LdtSupplyDate { get; set; }

    public decimal? LdtStartLatitude { get; set; }

    public decimal? LdtEndLatitude { get; set; }

    public decimal? LdtStartLongitude { get; set; }

    public decimal? LdtEndLongitude { get; set; }

    public bool? LdtAssigned { get; set; }

    public bool? LdtBundled { get; set; }

    public bool? LdtPlantLine { get; set; }

    public bool? LdtVerified { get; set; }

    public bool? LdtShowInStationReadings { get; set; }

    public bool? LdtActive { get; set; }

    public string? LdtRmks { get; set; }

    public int? LdtCreatedBy { get; set; }

    public int? LdtEditedBy { get; set; }

    public DateTime? LdtCreationDate { get; set; }

    public DateTime? LdtEditedDate { get; set; }
}
