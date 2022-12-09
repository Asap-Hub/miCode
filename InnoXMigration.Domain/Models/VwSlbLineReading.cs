using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class VwSlbLineReading
{
    public int LrdIdpk { get; set; }

    public int LrdStationIdfk { get; set; }

    public int LrdLineIdfk { get; set; }

    public DateTime? LrdTime { get; set; }

    public decimal LrdVoltage { get; set; }

    public decimal LrdCurrent { get; set; }

    public decimal LrdActivePower { get; set; }

    public decimal LrdReactivePower { get; set; }

    public bool LrdActive { get; set; }

    public string LrdRmks { get; set; } = null!;

    public int Ldtidpk { get; set; }

    public string LdtName { get; set; } = null!;

    public int StnIdpk { get; set; }

    public string StnContact { get; set; } = null!;

    public string StnTelNo { get; set; } = null!;

    public int LocIdpk { get; set; }

    public string LocName { get; set; } = null!;

    public string LocShtName { get; set; } = null!;

    public string AreName { get; set; } = null!;

    public string AreShtName { get; set; } = null!;

    public int AreIdpk { get; set; }

    public string StnName { get; set; } = null!;

    public string StnShtName { get; set; } = null!;

    public int? SourceStationId { get; set; }

    public string? SourceStationName { get; set; }

    public string? SourceStationShtName { get; set; }

    public int? DestStationId { get; set; }

    public string? DestStationName { get; set; }

    public string? DestStationShtName { get; set; }

    public string? LdtNomenclature { get; set; }

    public int? LdtSourceStationIdfk { get; set; }

    public decimal? LdtLength { get; set; }

    public decimal? LdtOperatingVoltage { get; set; }

    public decimal? LdtThermalLimit { get; set; }

    public bool? LdtBundled { get; set; }
}
