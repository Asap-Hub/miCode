using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblBlxFdrMultAssign
{
    public int FfmtIdpk { get; set; }

    public int? FfmtFdrIdfk { get; set; }

    public DateTime? FfmtDate { get; set; }

    public double? FfmtMultiplier { get; set; }

    public string? FfmtRmks { get; set; }

    public int? FfmtCreatedBy { get; set; }

    public int? FfmtEditedBy { get; set; }

    public DateTime? FfmtEditedDate { get; set; }

    public DateTime? FfmtCreationDate { get; set; }
}
