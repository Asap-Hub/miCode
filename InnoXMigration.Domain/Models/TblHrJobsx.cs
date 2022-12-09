using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblHrJobsx
{
    public int FjobIdpk { get; set; }

    public string? FjobName { get; set; }

    public string? FjobShtName { get; set; }

    public bool? FjobActive { get; set; }

    public string? FjobRmks { get; set; }

    public int? FjobCreatedBy { get; set; }

    public int? FjobEditedBy { get; set; }

    public DateTime? FjobCreationDate { get; set; }

    public DateTime? FjobEditedDate { get; set; }
}
