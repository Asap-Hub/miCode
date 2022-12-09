using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblSlbOperatorsx
{
    public int FoprIdpk { get; set; }

    public int? FoprEmpIdfk { get; set; }

    public DateTime? FoprDate { get; set; }

    public bool? FoprIsShiftLeader { get; set; }

    public bool? FoprSeeAllLogs { get; set; }

    public int? FoprSubstationIdfk { get; set; }

    public bool? FoprActive { get; set; }

    public string? FoprRmks { get; set; }

    public int? FoprCreatedBy { get; set; }

    public int? FoprEditedBy { get; set; }

    public DateTime? FoprCreationDate { get; set; }

    public DateTime? FoprEditedDate { get; set; }
}
