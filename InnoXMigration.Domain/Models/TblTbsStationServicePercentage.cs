using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblTbsStationServicePercentage
{
    public int SspIdpk { get; set; }

    public DateTime? SspStartDate { get; set; }

    public DateTime? SspEndDate { get; set; }

    public int? SspFeederIdfk { get; set; }

    public int? SspCustIdfk { get; set; }

    public decimal? SspPercentage { get; set; }

    public string? SspRmks { get; set; }

    public int? SspCreatedBy { get; set; }

    public int? SspEditedBy { get; set; }

    public DateTime? SspCreationDate { get; set; }

    public DateTime? SspEditedDate { get; set; }
}
