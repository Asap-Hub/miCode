using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblPfmCorporateInitiative
{
    public int CinIdpk { get; set; }

    public int? CinPerspectiveIdfk { get; set; }

    public string? CinName { get; set; }

    public string? CinShtName { get; set; }

    public DateTime? CinStartDate { get; set; }

    public DateTime? CinEndDate { get; set; }

    public bool? CinActive { get; set; }

    public string? CinRmks { get; set; }

    public string? CinCreatedBy { get; set; }

    public int? CinEditedBy { get; set; }

    public DateTime? CinCreationDate { get; set; }

    public DateTime? CinEditedDate { get; set; }
}
