using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblPmgInitiativeAssignment
{
    public int IasIdpk { get; set; }

    public int? IasPeriodIdfk { get; set; }

    public int? IasSectionIdfk { get; set; }

    public int? IasObjectiveIdfk { get; set; }

    public int? IasInitiativeIdfk { get; set; }

    public bool? IasActive { get; set; }

    public string? IasRmks { get; set; }

    public int? IasCreatedBy { get; set; }

    public int? IasEditedBy { get; set; }

    public DateTime? IasCreationDate { get; set; }

    public DateTime? IasEditedDate { get; set; }
}
