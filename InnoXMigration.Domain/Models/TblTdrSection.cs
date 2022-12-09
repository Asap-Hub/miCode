using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblTdrSection
{
    public int DsnIdpk { get; set; }

    public string? DsnName { get; set; }

    public string? DsnShtName { get; set; }

    public bool? DsnActive { get; set; }

    public string? DsnRmks { get; set; }

    public int? DsnCreatedBy { get; set; }

    public int? DsnEditedBy { get; set; }

    public DateTime? DsnCreationDate { get; set; }

    public DateTime? DsnEditedDate { get; set; }
}
