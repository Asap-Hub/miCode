using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblHrEducationalInstitution
{
    public int EdiIdpk { get; set; }

    public string? EdiName { get; set; }

    public string? EdiShtName { get; set; }

    public int? EdiInstTypeIdfk { get; set; }

    public int? EdiInstGroupIdfk { get; set; }

    public int? EdiInstCategoryIdfk { get; set; }

    public int? EdiDenominationIdfk { get; set; }

    public int? EdiTownIdfk { get; set; }

    public string? EdiAddress { get; set; }

    public string? EdiAddressOthers { get; set; }

    public string? EdiTelNo { get; set; }

    public string? EdiTelNoOthers { get; set; }

    public string? EdiMobNo { get; set; }

    public string? EdiMobNoOthers { get; set; }

    public string? EdiWebsite { get; set; }

    public string? EdiEmail { get; set; }

    public string? EdiEmailOthers { get; set; }

    public string? EdiFax { get; set; }

    public string? EdiFaxOthers { get; set; }

    public string? EdiSkype { get; set; }

    public string? EdiTwitter { get; set; }

    public string? EdiFacebook { get; set; }

    public string? EdiLinkedIn { get; set; }

    public bool? EdiEducInstitution { get; set; }

    public bool? EdiTrainingInstitution { get; set; }

    public bool? EdiActive { get; set; }

    public string? EdiRmks { get; set; }

    public int? EdiCreatedBy { get; set; }

    public int? EdiEditedBy { get; set; }

    public DateTime? EdiCreationDate { get; set; }

    public DateTime? EdiEditedDate { get; set; }
}
