using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class VwSlbBusReading
{
    public int BrdIdpk { get; set; }

    public int? BrdStationIdfk { get; set; }

    public int? BrdBusIdfk { get; set; }

    public DateTime? BrdTime { get; set; }

    public decimal? BrdVoltage { get; set; }

    public bool? BrdActive { get; set; }

    public string? BrdRmks { get; set; }

    public int? BrdCreatedBy { get; set; }

    public int? StnIdpk { get; set; }

    public string? StnName { get; set; }

    public string? StnShtName { get; set; }

    public string? StnCode { get; set; }

    public string? StnContact { get; set; }

    public int? LocIdpk { get; set; }

    public string? LocName { get; set; }

    public string? LocShtName { get; set; }

    public int? AreIdpk { get; set; }

    public string? AreName { get; set; }

    public string? AreShtName { get; set; }

    public int? BdtIdpk { get; set; }

    public int? BdtStationIdfk { get; set; }

    public string? BdtName { get; set; }

    public string? BdtShtName { get; set; }

    public bool? BdtActive { get; set; }

    public string? BdtRmks { get; set; }
}
