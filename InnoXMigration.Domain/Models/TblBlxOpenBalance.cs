using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblBlxOpenBalance
{
    public int FopbIdpk { get; set; }

    public DateTime? FopbDate { get; set; }

    public int? FopbCustIdfk { get; set; }

    public double? FopbAmountGhc { get; set; }

    public double? FopbAmountUsd { get; set; }

    public string? FopbRmks { get; set; }

    public int? FopbCreatedBy { get; set; }

    public int? FopbEditedBy { get; set; }

    public DateTime? FopbEditedDate { get; set; }

    public DateTime? FopbCreationDate { get; set; }
}
