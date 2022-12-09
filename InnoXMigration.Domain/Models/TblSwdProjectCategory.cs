using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblSwdProjectCategory
{
    public int PrcIdpk { get; set; }

    public string? PrcName { get; set; }

    public string? PrcShtName { get; set; }

    public bool? PrcActive { get; set; }

    public string? PrcRmks { get; set; }

    public int? PrcCreatedBy { get; set; }

    public int? PrcEditedBy { get; set; }

    public DateTime? PrcCreationDate { get; set; }

    public DateTime? PrcEditedDate { get; set; }
}
