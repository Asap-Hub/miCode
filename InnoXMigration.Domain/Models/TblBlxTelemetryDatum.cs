using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblBlxTelemetryDatum
{
    public int TmdIdpk { get; set; }

    public DateTime? TmdStartDate { get; set; }

    public DateTime? TmdEndDate { get; set; }

    public string? TmdArea { get; set; }

    public string? TmdSubstation { get; set; }

    public string? TmdFeederNo { get; set; }

    public string? TmdMeterNo { get; set; }

    public string? TmdCustomer { get; set; }

    public string? TmdActiveEnergyKwh { get; set; }

    public decimal? TmdActiveEnergyKwhx { get; set; }

    public string? TmdReactiveEnergyKvarh { get; set; }

    public decimal? TmdReactiveEnergyKvarhx { get; set; }

    public string? TmdMaxDemandKw { get; set; }

    public decimal? TmdMaxDemandKwx { get; set; }

    public string? TmdMaxDemandKvar { get; set; }

    public string? TmdMaxDemandKvarx { get; set; }

    public string? TmdMaxDemandKva { get; set; }

    public string? TmdMaxDemandKvax { get; set; }

    public string? TmdPowerFactor { get; set; }

    public string? TmdRmks { get; set; }

    public int? TmdCreatedBy { get; set; }

    public int? TmdEditedBy { get; set; }

    public DateTime? TmdCreationDate { get; set; }

    public DateTime? TmdEditedDate { get; set; }
}
