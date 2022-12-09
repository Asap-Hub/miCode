using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class VwSlbStationBusVoltage
{
    public int SbvIdpk { get; set; }

    public int? SbvStationIdfk { get; set; }

    public int? SbvBusIdfk { get; set; }

    public DateTime? SbvTime { get; set; }

    public decimal? SbvVoltage { get; set; }

    public bool? SbvActive { get; set; }

    public string? SbvRmks { get; set; }

    public int? SbvCreatedBy { get; set; }

    public int StnIdpk { get; set; }

    public string StnName { get; set; } = null!;

    public string StnShtName { get; set; } = null!;

    public string StnCode { get; set; } = null!;

    public string StnContact { get; set; } = null!;

    public int LocIdpk { get; set; }

    public string LocName { get; set; } = null!;

    public string LocShtName { get; set; } = null!;

    public int AreIdpk { get; set; }

    public string AreName { get; set; } = null!;

    public string AreShtName { get; set; } = null!;

    public int SbdIdpk { get; set; }

    public int? SbdStationIdfk { get; set; }

    public string? SbdName { get; set; }

    public string? SbdShtName { get; set; }

    public bool? SbdActive { get; set; }

    public string? SbdRmks { get; set; }
}
