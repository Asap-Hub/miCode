using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblHrEmpsStatus
{
    public short EstIdpk { get; set; }

    public string? EstName { get; set; }

    public string? EstShtName { get; set; }

    public int? EstCreatedBy { get; set; }

    public int? EstEditedBy { get; set; }

    public DateTime? EstCreationDate { get; set; }

    public DateTime? EstEditedDate { get; set; }
}
