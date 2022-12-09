using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblHrJobLevel
{
    public int JlvIdpk { get; set; }

    public string? JlvName { get; set; }

    public string? JlvShtName { get; set; }

    public byte? JlvOrder { get; set; }

    public bool? JlvActive { get; set; }

    public string? JlvRmks { get; set; }

    public int? JlvCreatedBy { get; set; }

    public int? JlvEditedBy { get; set; }

    public DateTime? JlvCreationDate { get; set; }

    public DateTime? JlvEditedDate { get; set; }
}
