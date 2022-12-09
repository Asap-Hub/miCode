using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblAsmRstAirConClass
{
    public int AccIdpk { get; set; }

    public string? AccName { get; set; }

    public string? AccShtName { get; set; }

    public bool? AccActive { get; set; }

    public string? AccRmks { get; set; }

    public string? AccCreatedBy { get; set; }

    public int? AccEditedBy { get; set; }

    public DateTime? AccCreationDate { get; set; }

    public DateTime? AccEditedDate { get; set; }
}
