using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblTlmLoadProfileOne
{
    public int LpoIdpk { get; set; }

    public int? LpoMeterAssignmentIdfk { get; set; }

    public DateTime? LpoDate { get; set; }

    public string? LpoEdisStatus { get; set; }

    public decimal? LpoActiveEnergykWh { get; set; }

    public decimal? LpoReactiveEnergykvarh { get; set; }

    public decimal? LpoMaximumActivePowerDemandkW { get; set; }

    public decimal? LpoMaximumReactivePowerDemandkvar { get; set; }

    public decimal? LpoMaximumApparentPowerDemandkVa { get; set; }

    public decimal? LpoPowerFactor { get; set; }

    public bool? LpoActive { get; set; }

    public string? LpoRmks { get; set; }

    public int? LpoCreatedBy { get; set; }

    public int? LpoEditedBy { get; set; }

    public DateTime? LpoCreationDate { get; set; }

    public DateTime? LpoEditedDate { get; set; }
}
