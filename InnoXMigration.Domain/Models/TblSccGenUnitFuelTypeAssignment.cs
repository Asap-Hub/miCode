using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblSccGenUnitFuelTypeAssignment
{
    public int GfaIdpk { get; set; }

    public int? GfaGenUnitIdfk { get; set; }

    public int? GfaFuelTypeIdfk { get; set; }

    public DateTime? GfaStartDate { get; set; }

    public DateTime? GfaEndDate { get; set; }

    public bool? GfaActive { get; set; }

    public string? GfaRmks { get; set; }

    public int? GfaCreatedBy { get; set; }

    public int? GfaEditedBy { get; set; }

    public DateTime? GfaCreationDate { get; set; }

    public DateTime? GfaEditedDate { get; set; }
}
