using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblTbsFeederMultiplierAssignment
{
    public int FmaIdpk { get; set; }

    public int? FmaFdrIdfk { get; set; }

    public DateTime? FmaStartDate { get; set; }

    public DateTime? FmaEndDate { get; set; }

    public double? FmaMultiplier { get; set; }

    public string? FmaRmks { get; set; }

    public int? FmaCreatedBy { get; set; }

    public int? FmaEditedBy { get; set; }

    public DateTime? FmaEditedDate { get; set; }

    public DateTime? FmaCreationDate { get; set; }
}
