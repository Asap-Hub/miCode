using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblAsmTmsFuelDumpDip
{
    public int FddIdpk { get; set; }

    public DateTime? FddDate { get; set; }

    public int? FddServiceStationIdfk { get; set; }

    public int? FddProductIdfk { get; set; }

    public decimal? FddTankCapacity { get; set; }

    public decimal? FddOpeningBalance { get; set; }

    public decimal? FddReceipt { get; set; }

    public decimal? FddIssue { get; set; }

    public decimal? FddClosingBalance { get; set; }

    public decimal? FddOpeningMeterReading { get; set; }

    public decimal? FddClosingMeterReading { get; set; }

    public decimal? FddOpeningDipBalance { get; set; }

    public bool? FddActive { get; set; }

    public string? FddRmks { get; set; }

    public string? FddCreatedBy { get; set; }

    public int? FddEditedBy { get; set; }

    public DateTime? FddCreationDate { get; set; }

    public DateTime? FddEditedDate { get; set; }
}
