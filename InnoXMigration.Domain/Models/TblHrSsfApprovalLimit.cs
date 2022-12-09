using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblHrSsfApprovalLimit
{
    public int SalIdpk { get; set; }

    public DateTime? SalDate { get; set; }

    public string? SalForm { get; set; }

    public string? SalApprovalCat { get; set; }

    public decimal? SalLowerLimit { get; set; }

    public decimal? SalUpperLimit { get; set; }

    public bool? SalActive { get; set; }

    public string? SalRmks { get; set; }

    public string? SalCreatedBy { get; set; }

    public int? SalEditedBy { get; set; }

    public DateTime? SalCreationDate { get; set; }

    public DateTime? SalEditedDate { get; set; }
}
