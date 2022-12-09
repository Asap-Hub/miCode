using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblHrCbfAward
{
    public int AwdIdpk { get; set; }

    public DateTime? AwdDate { get; set; }

    public int? AwdAnniversaryIdfk { get; set; }

    public decimal? AwdPercentOfBasicSalary { get; set; }

    public decimal? AwdFlatAmount { get; set; }

    public bool? AwdActive { get; set; }

    public string? AwdRmks { get; set; }

    public string? AwdCreatedBy { get; set; }

    public int? AwdEditedBy { get; set; }

    public DateTime? AwdCreationDate { get; set; }

    public DateTime? AwdEditedDate { get; set; }
}
