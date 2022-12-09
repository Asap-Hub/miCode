using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class VwAsmTamLineDetail
{
    public int LdtIdpk { get; set; }

    public string? LdtName { get; set; }

    public string LdtNomenclature { get; set; } = null!;

    public int LdtSourceStationIdfk { get; set; }

    public int? LdtDestinationStationIdfk { get; set; }

    public decimal? LdtLength { get; set; }

    public DateTime? LdtConstructionDate { get; set; }

    public DateTime? LdtCommissionDate { get; set; }

    public DateTime? LdtDecommissionDate { get; set; }

    public decimal? LdtOperatingVoltage { get; set; }

    public int? LdtConductorTypeIdfk { get; set; }

    public int? LdtConductorCodeNameIdfk { get; set; }

    public decimal? LdtConductorCrossSectionalArea { get; set; }

    public decimal? LdtPositiveSeqResistancePerKm { get; set; }

    public decimal? LdtPositiveSeqReactancePerKm { get; set; }

    public double? LdtSusceptancePerKm { get; set; }

    public decimal? LdtResistanceOn100MvaBase { get; set; }

    public decimal? LdtReactanceOn100MvaBase { get; set; }

    public double? LdtSusceptanceOn100MvaBase { get; set; }

    public decimal? LdtZeroSeqResistance { get; set; }

    public decimal? LdtZeroSeqReactance { get; set; }

    public double LdtZeroSeqSusceptance { get; set; }

    public decimal LdtZeroSeqResistanceOn100MvaBase { get; set; }

    public decimal LdtZeroSeqReactanceOn100MvaBase { get; set; }

    public double LdtZeroSeqSusceptanceOn100MvaBase { get; set; }

    public decimal LdtThermalLimit { get; set; }

    public decimal? LdtSurgeImpedanceLoading { get; set; }

    public bool LdtAssigned { get; set; }

    public bool LdtBundled { get; set; }

    public bool LdtActive { get; set; }

    public string LdtRmks { get; set; } = null!;

    public int? LdtCreatedBy { get; set; }

    public int? LdtEditedBy { get; set; }

    public DateTime? LdtCreationDate { get; set; }

    public DateTime? LdtEditedDate { get; set; }

    public int? SourceStationId { get; set; }

    public string? SourceStationName { get; set; }

    public string? SourceStationShtName { get; set; }

    public string? SourceStationCode { get; set; }

    public string? SourceStationContacts { get; set; }

    public string? SourceStationTelNos { get; set; }

    public string? SourceStationPlcs { get; set; }

    public string? SourceStationEmails { get; set; }

    public bool? SourceStationActive { get; set; }

    public string? SourceStationRmks { get; set; }

    public string? SourceStationTownName { get; set; }

    public string? SourceStationTownShtName { get; set; }

    public int? SourceStationRegionId { get; set; }

    public string? SourceStationRegionName { get; set; }

    public string? SourceStationRegionShtName { get; set; }

    public int? SourceStationCountryId { get; set; }

    public string? SourceStationCountryName { get; set; }

    public string? SourceStationCountryShtName { get; set; }

    public string? SourceStationCountryNationality { get; set; }

    public string? SourceStationRegionCapital { get; set; }

    public string? SourceStationCountryCapital { get; set; }

    public int? CcnIdpk { get; set; }

    public string? CcnName { get; set; }

    public string? CcnShtName { get; set; }

    public bool? CcnActive { get; set; }

    public string? CcnRmks { get; set; }

    public int? CdtIdpk { get; set; }

    public string? CdtName { get; set; }

    public string? CdtShtName { get; set; }

    public bool? CdtActive { get; set; }

    public string? CdtRmks { get; set; }

    public int? DestStationId { get; set; }

    public string? DestStationName { get; set; }

    public string? DestStationShtName { get; set; }

    public string? DestStationCode { get; set; }

    public string? DestStationContacts { get; set; }

    public string? DestStationTelNos { get; set; }

    public string? DestStationPlcs { get; set; }

    public string? DestStationEmails { get; set; }

    public bool? DestStationActive { get; set; }

    public string? DestStationRmks { get; set; }

    public string? DestStationTownName { get; set; }

    public string? DestStationTownShtName { get; set; }

    public int? DestStationRegionId { get; set; }

    public string? DestStationRegionName { get; set; }

    public string? DestStationRegionShtName { get; set; }

    public int? DestStationCountryId { get; set; }

    public string? DestStationCountryName { get; set; }

    public string? DestStationCountryShtName { get; set; }

    public string? DestStationCountryNationality { get; set; }

    public string? DestStationRegionCapital { get; set; }

    public string? DestStationCountryCapital { get; set; }

    public decimal LdtStartLatitude { get; set; }

    public decimal LdtEndLatitude { get; set; }

    public decimal LdtStartLongitude { get; set; }

    public decimal LdtEndLongitude { get; set; }

    public int? MftIdpk { get; set; }

    public string? MftName { get; set; }

    public string? MftShtName { get; set; }

    public bool? MftActive { get; set; }

    public int? LdtManufacturerIdfk { get; set; }

    public int? LdtLocationIdfk { get; set; }

    public int TalIdpk { get; set; }

    public string? TalName { get; set; }

    public string? TalShtName { get; set; }

    public bool? TalActive { get; set; }

    public DateTime? LdtManufactureDate { get; set; }

    public DateTime? LdtSupplyDate { get; set; }

    public bool LdtVerified { get; set; }

    public bool LdtShowInStationReadings { get; set; }

    public bool LdtPlantLine { get; set; }

    public int IntIdpk { get; set; }

    public string IntName { get; set; } = null!;

    public string IntShtName { get; set; } = null!;

    public int TdtIdpk { get; set; }

    public string TdtName { get; set; } = null!;

    public string TdtShtName { get; set; } = null!;

    public int CtcIdpk { get; set; }

    public string CtcName { get; set; } = null!;

    public string CtcShtName { get; set; } = null!;
}
