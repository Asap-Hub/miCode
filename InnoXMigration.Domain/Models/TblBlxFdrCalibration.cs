using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblBlxFdrCalibration
{
    public int FfclIdpk { get; set; }

    public DateTime? FfclStartDate { get; set; }

    public DateTime? FfclEndDate { get; set; }

    public int? FfclFdrIdfk { get; set; }

    public string? FfclRmks { get; set; }

    public int? FfclCreatedBy { get; set; }

    public DateTime? FfclCreationDate { get; set; }

    public int? FfclEditedBy { get; set; }

    public DateTime? FfclEditedDate { get; set; }
}
