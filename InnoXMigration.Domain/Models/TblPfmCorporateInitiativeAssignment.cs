using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblPfmCorporateInitiativeAssignment
{
    public int CiaIdpk { get; set; }

    public int? CiaPeriodIdfk { get; set; }

    public int? CiaObjectiveIdfk { get; set; }

    public int? CiaInitiativeIdfk { get; set; }

    public bool? CiaActive { get; set; }

    public string? CiaRmks { get; set; }

    public int? CiaCreatedBy { get; set; }

    public int? CiaEditedBy { get; set; }

    public DateTime? CiaCreationDate { get; set; }

    public DateTime? CiaEditedDate { get; set; }
}
