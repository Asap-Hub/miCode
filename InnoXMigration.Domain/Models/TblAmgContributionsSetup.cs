using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblAmgContributionsSetup
{
    public int CesIdpk { get; set; }

    public DateTime? CesDate { get; set; }

    public string? CesElement { get; set; }

    public int? CesAssociationIdfk { get; set; }

    public bool? CesDeductFromPayroll { get; set; }

    public bool? CesActive { get; set; }

    public string? CesRmks { get; set; }

    public int? CesCreatedBy { get; set; }

    public int? CesEditedBy { get; set; }

    public DateTime? CesCreationDate { get; set; }

    public DateTime? CesEditedDate { get; set; }
}
