using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblTbsBill
{
    public int? BlsIdpk { get; set; }

    public int? BlsBillNameIdfk { get; set; }

    public int? BlsFeederIdfk { get; set; }

    public int? BlsCustIdfk { get; set; }

    public int? BlsSstIdfk { get; set; }

    public int? BlsMultiplierIdfk { get; set; }

    public int? BlsMeterReadingIdfk { get; set; }

    public int? BlsTsridfk { get; set; }

    public int? BlsRlridfk { get; set; }

    public short? BlsSign { get; set; }

    public decimal? BlsStatServPercent { get; set; }

    public decimal? BlsDifference { get; set; }

    public decimal? BlsEnergyConsumed { get; set; }

    public decimal? BlsRegLevy { get; set; }

    public decimal? BlsTscharge { get; set; }

    public decimal? BlsAncilliaryLevy { get; set; }

    public decimal? BlsPowerInfrasLevy { get; set; }

    public int? BlsCreatedBy { get; set; }

    public DateTime? BlsCreationDate { get; set; }
}
