using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblVrgServiceFacility
{
    public int FsfcIdpk { get; set; }

    public string? FsfcName { get; set; }

    public string? FsfcShtName { get; set; }

    public bool? FsfcActive { get; set; }

    public string? FsfcRmks { get; set; }

    public int? FsfcCreatedBy { get; set; }

    public int? FsfcEditedBy { get; set; }

    public DateTime? FsfcCreationDate { get; set; }

    public DateTime? FsfcEditedDate { get; set; }
}
