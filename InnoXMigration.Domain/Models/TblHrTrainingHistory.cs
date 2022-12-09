using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblHrTrainingHistory
{
    public int ThsIdpk { get; set; }

    public int? ThsProgIdfk { get; set; }

    public string? ThsProgModules { get; set; }

    public decimal? ThsAmountProvisioned { get; set; }

    public decimal? ThsAmountSpent { get; set; }

    public int? ThsTrainingTypeIdfk { get; set; }

    public string? ThsDeliveryMethod { get; set; }

    public int? ThsInstitutionIdfk { get; set; }

    public string? ThsDeliveredBy { get; set; }

    public int? ThsCountryIdfk { get; set; }

    public int? ThsRegionIdfk { get; set; }

    public int? ThsLocationIdfk { get; set; }

    public string? ThsTown { get; set; }

    public int? ThsAmtProvisionedCurrencyIdfk { get; set; }

    public int? ThsAmtSpentCurrencyIdfk { get; set; }

    public int? ThsSponsorIdfk { get; set; }

    public DateTime? ThsStartDate { get; set; }

    public DateTime? ThsEndDate { get; set; }

    public string? ThsCostDescription { get; set; }

    public bool? ThsGroupCost { get; set; }

    public short? ThsNumberOfParticipants { get; set; }

    public bool? ThsActive { get; set; }

    public string? ThsRmks { get; set; }

    public int? ThsCreatedBy { get; set; }

    public int? ThsEditedBy { get; set; }

    public DateTime? ThsCreationDate { get; set; }

    public DateTime? ThsEditedDate { get; set; }
}
