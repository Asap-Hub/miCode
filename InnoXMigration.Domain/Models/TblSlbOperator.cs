using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblSlbOperator
{
    public int OprIdpk { get; set; }

    public int? OprEmpIdfk { get; set; }

    public DateTime? OprDate { get; set; }

    public bool? OprIsShiftLeader { get; set; }

    public bool? OprSeeAllLogs { get; set; }

    public int? OprSubstationIdfk { get; set; }

    public bool? OprActive { get; set; }

    public string? OprRmks { get; set; }

    public int? OprCreatedBy { get; set; }

    public int? OprEditedBy { get; set; }

    public DateTime? OprCreationDate { get; set; }

    public DateTime? OprEditedDate { get; set; }
}
