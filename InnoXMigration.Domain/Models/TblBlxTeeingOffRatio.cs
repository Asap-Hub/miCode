using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblBlxTeeingOffRatio
{
    public int FtorIdpk { get; set; }

    public DateTime? FtorDate { get; set; }

    public int? FtorParentCustIdfk { get; set; }

    public int? FtorChildCustIdfk { get; set; }

    public int? FtorParentFeederIdfk { get; set; }

    public int? FtorChildFeederIdfk { get; set; }

    public decimal? FtorParentRatio { get; set; }

    public decimal? FtorChildRatio { get; set; }

    public string? FtorRmks { get; set; }

    public int? FtorCreatedBy { get; set; }

    public int? FtorEditedBy { get; set; }

    public DateTime? FtorCreationDate { get; set; }

    public DateTime? FtorEditedDate { get; set; }
}
