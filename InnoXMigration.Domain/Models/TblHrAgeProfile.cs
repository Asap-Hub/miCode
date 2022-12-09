using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblHrAgeProfile
{
    public int ApfIdpk { get; set; }

    public string? ApfName { get; set; }

    public string? ApfShtName { get; set; }

    public decimal? ApfStartAge { get; set; }

    public decimal? ApfEndAge { get; set; }

    public byte? ApfOrder { get; set; }

    public bool? ApfActive { get; set; }

    public string? ApfRmks { get; set; }

    public int? ApfCreatedBy { get; set; }

    public int? ApfEditedBy { get; set; }

    public DateTime? ApfCreationDate { get; set; }

    public DateTime? ApfEditedDate { get; set; }
}
