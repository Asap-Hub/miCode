using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblAcsApplicant
{
    public int FappIdpk { get; set; }

    public string? FappName { get; set; }

    public string? FappShtName { get; set; }

    public int? FappApplTypeIdfk { get; set; }

    public int? FappTownIdfk { get; set; }

    public int? FappStageIdfk { get; set; }

    public int? FappContactIdfk { get; set; }

    public string? FappContact { get; set; }

    public string? FappMobNo { get; set; }

    public string? FappEmail { get; set; }

    public string? FappTelNo { get; set; }

    public int? FappSalutationIdfk { get; set; }

    public int? FappPaymentIdfk { get; set; }

    public bool? FappActive { get; set; }

    public string? FappAddress { get; set; }

    public string? FappRmks { get; set; }

    public int? FappCreatedBy { get; set; }

    public int? FappEditedBy { get; set; }

    public DateTime? FappCreationDate { get; set; }

    public DateTime? FappEditedDate { get; set; }
}
