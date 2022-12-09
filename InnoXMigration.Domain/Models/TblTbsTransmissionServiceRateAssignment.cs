using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblTbsTransmissionServiceRateAssignment
{
    public int TraIdpk { get; set; }

    public int? TraCustIdfk { get; set; }

    public double? TraRate { get; set; }

    public DateTime? TraDate { get; set; }

    public string? TraRmks { get; set; }

    public int? TraCreatedBy { get; set; }

    public int? TraEditedBy { get; set; }

    public DateTime? TraCreationDate { get; set; }

    public DateTime? TraEditedDate { get; set; }
}
