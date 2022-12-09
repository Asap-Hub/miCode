using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblHrTitle
{
    public int TitIdpk { get; set; }

    public string? TitName { get; set; }

    public string? TitShtName { get; set; }

    public bool? TitActive { get; set; }

    public string? TitRmks { get; set; }

    public int? TitCreatedBy { get; set; }

    public int? TitEditedBy { get; set; }

    public DateTime? TitCreationDate { get; set; }

    public DateTime? TitEditedDate { get; set; }
}
