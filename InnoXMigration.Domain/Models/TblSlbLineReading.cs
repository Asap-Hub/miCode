using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblSlbLineReading
{
    public int LrdIdpk { get; set; }

    public int? LrdStationIdfk { get; set; }

    public int? LrdLineIdfk { get; set; }

    public DateTime? LrdTime { get; set; }

    public decimal? LrdVoltage { get; set; }

    public decimal? LrdCurrent { get; set; }

    public decimal? LrdActivePower { get; set; }

    public decimal? LrdReactivePower { get; set; }

    public bool? LrdActive { get; set; }

    public string? LrdRmks { get; set; }

    public int? LrdCreatedBy { get; set; }

    public int? LrdEditedBy { get; set; }

    public DateTime? LrdCreationDate { get; set; }

    public DateTime? LrdEditedDate { get; set; }
}
