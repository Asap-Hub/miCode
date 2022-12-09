using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblTbsTeeingOffRatio
{
    public int TorIdpk { get; set; }

    public DateTime? TorDate { get; set; }

    public int? TorParentCustIdfk { get; set; }

    public int? TorChildCustIdfk { get; set; }

    public int? TorParentFeederIdfk { get; set; }

    public int? TorChildFeederIdfk { get; set; }

    public decimal? TorParentRatio { get; set; }

    public decimal? TorChildRatio { get; set; }

    public string? TorRmks { get; set; }

    public int? TorCreatedBy { get; set; }

    public int? TorEditedBy { get; set; }

    public DateTime? TorCreationDate { get; set; }

    public DateTime? TorEditedDate { get; set; }
}
