using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblLglCaseCategory
{
    public int CctIdpk { get; set; }

    public string? CctName { get; set; }

    public string? CctShtName { get; set; }

    public bool? CctActive { get; set; }

    public byte? CctOrder { get; set; }

    public string? CctRmks { get; set; }

    public int? CctCreatedBy { get; set; }

    public int? CctEditedBy { get; set; }

    public DateTime? CctCreationDate { get; set; }

    public DateTime? CctEditedDate { get; set; }
}
