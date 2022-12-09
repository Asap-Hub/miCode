using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblSlbMeterReading
{
    public int MrdIdpk { get; set; }

    public DateTime? MrdDate { get; set; }

    public int? MrdFeederIdfk { get; set; }

    public decimal? MrdkWhpresent { get; set; }

    public decimal? MrdkWhprevious { get; set; }

    public decimal? MrdkVarhPresent { get; set; }

    public decimal? MrdkVarhPrevious { get; set; }

    public decimal? MrdDemand { get; set; }

    public string? MrdRmks { get; set; }

    public int? MrdCreatedBy { get; set; }

    public int? MrdEditedBy { get; set; }

    public DateTime? MrdCreationDate { get; set; }

    public DateTime? MrdEditedDate { get; set; }
}
