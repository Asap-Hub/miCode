using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblSlbBusReading
{
    public int BrdIdpk { get; set; }

    public int? BrdStationIdfk { get; set; }

    public int? BrdBusIdfk { get; set; }

    public DateTime? BrdTime { get; set; }

    public decimal? BrdVoltage { get; set; }

    public bool? BrdActive { get; set; }

    public string? BrdRmks { get; set; }

    public int? BrdCreatedBy { get; set; }

    public int? BrdEditedBy { get; set; }

    public DateTime? BrdCreationDate { get; set; }

    public DateTime? BrdEditedDate { get; set; }
}
