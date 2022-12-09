using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblAcsRating
{
    public int FprtIdpk { get; set; }

    public string? FprtName { get; set; }

    public string? FprtShtName { get; set; }

    public string? FprtUnit { get; set; }

    public bool? FprtActive { get; set; }

    public string? FprtRmks { get; set; }

    public int? FprtCreatedBy { get; set; }

    public int? FprtEditedBy { get; set; }

    public DateTime? FprtCreationDate { get; set; }

    public DateTime? FprtEditedDate { get; set; }
}
