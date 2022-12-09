using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblHrEmpSmsErrorsx
{
    public int SemIdpk { get; set; }

    public string SemMobNo { get; set; } = null!;

    public string? SemErrorMessage { get; set; }

    public string? SemFormCode { get; set; }

    public int? SemCreatedBy { get; set; }

    public DateTime? SemCreationDate { get; set; }
}
