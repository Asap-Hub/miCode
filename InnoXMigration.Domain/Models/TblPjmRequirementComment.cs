using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblPjmRequirementComment
{
    public int PrcIdpk { get; set; }

    public int? PrcProjectIdfk { get; set; }

    public int? PrcEmpIdfk { get; set; }

    public string? PrcComment { get; set; }

    public bool? PrcActive { get; set; }

    public int? PrcCreatedBy { get; set; }

    public int? PrcEditedBy { get; set; }

    public DateTime? PrcCreationDate { get; set; }

    public DateTime? PrcEditedDate { get; set; }
}
