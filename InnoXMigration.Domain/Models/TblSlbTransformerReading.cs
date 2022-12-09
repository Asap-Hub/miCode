using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblSlbTransformerReading
{
    public int TrdIdpk { get; set; }

    public int? TrdStationIdfk { get; set; }

    public int? TrdTransformerIdfk { get; set; }

    public DateTime? TrdTime { get; set; }

    public decimal? TrdVoltage { get; set; }

    public decimal? TrdCurrent { get; set; }

    public decimal? TrdActivePower { get; set; }

    public decimal? TrdReactivePower { get; set; }

    public decimal? TrdTapChanger { get; set; }

    public decimal? TrdMinimumOilTemperature { get; set; }

    public decimal? TrdMaximumOilTemperature { get; set; }

    public decimal? TrdMinimumWindingTemperature1 { get; set; }

    public decimal? TrdMaximumWindingTemperature1 { get; set; }

    public decimal? TrdMinimumWindingTemperature2 { get; set; }

    public decimal? TrdMaximumWindingTemperature2 { get; set; }

    public bool? TrdActive { get; set; }

    public string? TrdRmks { get; set; }

    public int? TrdCreatedBy { get; set; }

    public int? TrdEditedBy { get; set; }

    public DateTime? TrdCreationDate { get; set; }

    public DateTime? TrdEditedDate { get; set; }
}
