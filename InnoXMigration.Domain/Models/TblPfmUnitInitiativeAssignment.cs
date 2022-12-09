using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblPfmUnitInitiativeAssignment
{
    public int UiaIdpk { get; set; }

    public int? UiaPeriodIdfk { get; set; }

    public int? UiaSectionIdfk { get; set; }

    public int? UiaUnitIdfk { get; set; }

    public int? UiaCorporateInitiativeAssignmentIdfk { get; set; }

    public int? UiaUnitInitiativeIdfk { get; set; }

    public bool? UiaActive { get; set; }

    public string? UiaRmks { get; set; }

    public int? UiaCreatedBy { get; set; }

    public int? UiaEditedBy { get; set; }

    public DateTime? UiaCreationDate { get; set; }

    public DateTime? UiaEditedDate { get; set; }
}
