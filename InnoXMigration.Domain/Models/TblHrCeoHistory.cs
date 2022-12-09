using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblHrCeoHistory
{
    public short CehIdpk { get; set; }

    public int? CehEmpIdfk { get; set; }

    public DateTime? CehDate { get; set; }

    public bool? CehIsCeo { get; set; }

    public string? CehRmks { get; set; }

    public int? CehCreatedBy { get; set; }

    public int? CehEditedBy { get; set; }

    public DateTime? CehCreationDate { get; set; }

    public DateTime? CehEditedDate { get; set; }
}
