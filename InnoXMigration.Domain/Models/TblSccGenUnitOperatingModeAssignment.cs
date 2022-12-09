using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblSccGenUnitOperatingModeAssignment
{
    public int GoaIdpk { get; set; }

    public int? GoaGenUnitIdfk { get; set; }

    public int? GoaOperatingModeIdfk { get; set; }

    public DateTime? GoaStartDate { get; set; }

    public DateTime? GoaEndDate { get; set; }

    public bool? GoaActive { get; set; }

    public string? GoaRmks { get; set; }

    public int? GoaCreatedBy { get; set; }

    public int? GoaEditedBy { get; set; }

    public DateTime? GoaCreationDate { get; set; }

    public DateTime? GoaEditedDate { get; set; }
}
