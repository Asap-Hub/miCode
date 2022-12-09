using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblSlbStationBusVoltage
{
    public int SbvIdpk { get; set; }

    public int? SbvStationIdfk { get; set; }

    public int? SbvBusIdfk { get; set; }

    public DateTime? SbvTime { get; set; }

    public decimal? SbvVoltage { get; set; }

    public bool? SbvActive { get; set; }

    public string? SbvRmks { get; set; }

    public int? SbvCreatedBy { get; set; }

    public int? SbvEditedBy { get; set; }

    public DateTime? SbvCreationDate { get; set; }

    public DateTime? SbvEditedDate { get; set; }
}
