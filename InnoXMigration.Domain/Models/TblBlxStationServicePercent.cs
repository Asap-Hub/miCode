using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblBlxStationServicePercent
{
    public int FsspIdpk { get; set; }

    public DateTime? FsspStartDate { get; set; }

    public DateTime? FsspEndDate { get; set; }

    public int? FsspFeederIdfk { get; set; }

    public int? FsspCustIdfk { get; set; }

    public decimal? FsspPercentage { get; set; }

    public string? FsspRmks { get; set; }

    public int? FsspCreatedBy { get; set; }

    public int? FsspEditedBy { get; set; }

    public DateTime? FsspCreationDate { get; set; }

    public DateTime? FsspEditedDate { get; set; }
}
