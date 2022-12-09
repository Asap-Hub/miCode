using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblTbsFeederCalibration
{
    public int FclIdpk { get; set; }

    public DateTime? FclStartDate { get; set; }

    public DateTime? FclEndDate { get; set; }

    public int? FclFdrIdfk { get; set; }

    public string? FclRmks { get; set; }

    public int? FclCreatedBy { get; set; }

    public DateTime? FclCreationDate { get; set; }

    public int? FclEditedBy { get; set; }

    public DateTime? FclEditedDate { get; set; }
}
