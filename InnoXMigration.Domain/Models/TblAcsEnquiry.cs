using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblAcsEnquiry
{
    public int FenqIdpk { get; set; }

    public DateTime? FenqDate { get; set; }

    public int? FenqApplIdfk { get; set; }

    public int? FenqPlantIdfk { get; set; }

    public int? FenqContactIdfk { get; set; }

    public int? FenqStageIdfk { get; set; }

    public bool? FenqActive { get; set; }

    public string? FenqRmks { get; set; }

    public int? FenqCreatedBy { get; set; }

    public int? FenqEditedBy { get; set; }

    public DateTime? FenqCreationDate { get; set; }

    public DateTime? FenqEditedDate { get; set; }
}
