using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblHrInstitutionType
{
    public int IntIdpk { get; set; }

    public string IntName { get; set; } = null!;

    public string IntShtName { get; set; } = null!;

    public string? IntShtCode { get; set; }

    public bool? IntActive { get; set; }

    public string? IntRmks { get; set; }

    public int? IntCreatedBy { get; set; }

    public int? IntEditedBy { get; set; }

    public DateTime? IntCreationDate { get; set; }

    public DateTime? IntEditedDate { get; set; }
}
