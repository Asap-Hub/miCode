using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class VwBlxStationServicePercent
{
    public int FsspIdpk { get; set; }

    public string FdrName { get; set; } = null!;

    public string? FcustShtName { get; set; }

    public DateTime? FsspStartDate { get; set; }

    public DateTime? FsspEndDate { get; set; }

    public decimal? FsspPercentage { get; set; }

    public int? FsspFeederIdfk { get; set; }

    public int? FsspCustIdfk { get; set; }

    public string? FsspRmks { get; set; }

    public int FcustIdpk { get; set; }

    public string? FcustName { get; set; }

    public int FdrIdpk { get; set; }

    public string FdrShtName { get; set; } = null!;

    public bool FdrActive { get; set; }

    public string? CustName { get; set; }
}
