using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblSlbFeederReading
{
    public int FrdIdpk { get; set; }

    public int? FrdStationIdfk { get; set; }

    public int? FrdFeederIdfk { get; set; }

    public DateTime? FrdTime { get; set; }

    public decimal? FrdVoltage { get; set; }

    public decimal? FrdCurrent { get; set; }

    public decimal? FrdActivePower { get; set; }

    public decimal? FrdReactivePower { get; set; }

    public bool? FrdActive { get; set; }

    public string? FrdRmks { get; set; }

    public int? FrdCreatedBy { get; set; }

    public int? FrdEditedBy { get; set; }

    public DateTime? FrdCreationDate { get; set; }

    public DateTime? FrdEditedDate { get; set; }
}
