using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblGenLoggerCategory
{
    public int LgcIdpk { get; set; }

    public string? LgcName { get; set; }

    public string? LgcShtName { get; set; }

    public bool? LgcTransport { get; set; }

    public bool? LgcElectricals { get; set; }

    public bool? LgcComputers { get; set; }

    public bool? LgcCommunications { get; set; }

    public bool? LgcRealEstate { get; set; }

    public bool? LgcAdmin { get; set; }

    public bool? LgcActive { get; set; }

    public string? LgcRmks { get; set; }

    public string? LgcCreatedBy { get; set; }

    public int? LgcEditedBy { get; set; }

    public DateTime? LgcCreationDate { get; set; }

    public DateTime? LgcEditedDate { get; set; }
}
