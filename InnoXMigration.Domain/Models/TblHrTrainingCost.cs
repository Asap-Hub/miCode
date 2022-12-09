using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblHrTrainingCost
{
    public int TncIdpk { get; set; }

    public int? TncEducHistoryIdfk { get; set; }

    public decimal? TncAmount { get; set; }

    public int? TncCurrencyIdfk { get; set; }

    public int? TncPayItemIdfk { get; set; }

    public int? TncSponsorIdfk { get; set; }

    public string? TncRmks { get; set; }

    public int? TncCreatedBy { get; set; }

    public int? TncEditedBy { get; set; }

    public DateTime? TncCreationDate { get; set; }

    public DateTime? TncEditedDate { get; set; }
}
