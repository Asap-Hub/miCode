using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class VwSlbTransformerReading
{
    public int TrdIdpk { get; set; }

    public int? TrdStationIdfk { get; set; }

    public int? TrdTransformerIdfk { get; set; }

    public DateTime? TrdTime { get; set; }

    public decimal? TrdActivePower { get; set; }

    public decimal? TrdReactivePower { get; set; }

    public decimal? TrdVoltage { get; set; }

    public decimal? TrdCurrent { get; set; }

    public decimal? TrdMinimumOilTemperature { get; set; }

    public decimal? TrdMaximumOilTemperature { get; set; }

    public bool? TrdActive { get; set; }

    public string? TrdRmks { get; set; }

    public int? StnIdpk { get; set; }

    public string? StnName { get; set; }

    public string? StnShtName { get; set; }

    public int? LocIdpk { get; set; }

    public string? LocName { get; set; }

    public string? LocShtName { get; set; }

    public int? TfdIdpk { get; set; }

    public string? TfdSerialNo { get; set; }

    public string? TfdTransformerId { get; set; }

    public decimal? TrdMinimumWindingTemperature1 { get; set; }

    public decimal? TrdMaximumWindingTemperature1 { get; set; }

    public decimal? TrdMinimumWindingTemperature2 { get; set; }

    public decimal? TrdMaximumWindingTemperature2 { get; set; }

    public decimal? TrdTapChanger { get; set; }
}
