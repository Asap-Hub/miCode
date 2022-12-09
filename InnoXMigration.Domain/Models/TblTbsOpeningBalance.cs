using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblTbsOpeningBalance
{
    public int OpbIdpk { get; set; }

    public DateTime? OpbDate { get; set; }

    public int? OpbCustIdfk { get; set; }

    public double? OpbAmountGhc { get; set; }

    public double? OpbAmountUsd { get; set; }

    public string? OpbRmks { get; set; }

    public int? OpbCreatedBy { get; set; }

    public int? OpbEditedBy { get; set; }

    public DateTime? OpbEditedDate { get; set; }

    public DateTime? OpbCreationDate { get; set; }
}
