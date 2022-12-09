using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblPjmRequirementImage
{
    public int PriIdpk { get; set; }

    public int? PriProjectIdfk { get; set; }

    public byte[]? PriImage { get; set; }

    public bool? PriActive { get; set; }

    public string? PriRmks { get; set; }

    public int? PriCreatedBy { get; set; }

    public int? PriEditedBy { get; set; }

    public DateTime? PriCreationDate { get; set; }

    public DateTime? PriEditedDate { get; set; }
}
