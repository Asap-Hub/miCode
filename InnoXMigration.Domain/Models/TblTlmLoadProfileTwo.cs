using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblTlmLoadProfileTwo
{
    public int LptIdpk { get; set; }

    public DateTime? LptDate { get; set; }

    public int? LptMeterAssignmentIdfk { get; set; }

    public string? LptEdisStatus { get; set; }

    public decimal? LptAphaseVoltageV { get; set; }

    public decimal? LptBphaseVoltageV { get; set; }

    public decimal? LptCphaseVoltageV { get; set; }

    public decimal? LptAphaseCurrentA { get; set; }

    public decimal? LptBphaseCurrentA { get; set; }

    public decimal? LptCphaseCurrentA { get; set; }

    public decimal? LptNeutralCurrentA { get; set; }

    public decimal? LptMainsFrequencyHz { get; set; }

    public decimal? LptActivePowerkW { get; set; }

    public decimal? LptReactivePowerkvar { get; set; }

    public decimal? LptPowerFactor { get; set; }

    public bool? LptActive { get; set; }

    public string? LptRmks { get; set; }

    public int? LptCreatedBy { get; set; }

    public int? LptEditedBy { get; set; }

    public DateTime? LptCreationDate { get; set; }

    public DateTime? LptEditedDate { get; set; }
}
