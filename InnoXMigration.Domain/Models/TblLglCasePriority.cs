using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblLglCasePriority
{
    public int CptIdpk { get; set; }

    public string? CptName { get; set; }

    public string? CptShtName { get; set; }

    public byte? CptOrder { get; set; }

    public bool? CptActive { get; set; }

    public string? CptRmks { get; set; }

    public int? CptCreatedBy { get; set; }

    public int? CptEditedBy { get; set; }

    public DateTime? CptCreationDate { get; set; }

    public DateTime? CptEditedDate { get; set; }
}
