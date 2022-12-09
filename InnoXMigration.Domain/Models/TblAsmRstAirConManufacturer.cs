using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblAsmRstAirConManufacturer
{
    public int AcmIdpk { get; set; }

    public string? AcmName { get; set; }

    public string? AcmShtName { get; set; }

    public bool? AcmActive { get; set; }

    public string? AcmRmks { get; set; }

    public string? AcmCreatedBy { get; set; }

    public int? AcmEditedBy { get; set; }

    public DateTime? AcmCreationDate { get; set; }

    public DateTime? AcmEditedDate { get; set; }
}
