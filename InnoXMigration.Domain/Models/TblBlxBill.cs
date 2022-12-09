using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblBlxBill
{
    public int? FblsIdpk { get; set; }

    public int? FblsBillNameIdfk { get; set; }

    public int? FblsFeederIdfk { get; set; }

    public int? FblsCustIdfk { get; set; }

    public int? FblsSstIdfk { get; set; }

    public int? FblsMultiplierIdfk { get; set; }

    public int? FblsMeterReadingIdfk { get; set; }

    public int? FblsTsridfk { get; set; }

    public int? FblsRlridfk { get; set; }

    public short? FblsSign { get; set; }

    public decimal? FblsStatServPercent { get; set; }

    public decimal? FblsDifference { get; set; }

    public decimal? FblsEnergyConsumed { get; set; }

    public decimal? FblsRegLevy { get; set; }

    public decimal? FblsTscharge { get; set; }

    public decimal? FblsAncilliaryLevy { get; set; }

    public decimal? FblsPowerInfrasLevy { get; set; }

    public int? FblsCreatedBy { get; set; }

    public DateTime? FblsCreationDate { get; set; }
}
