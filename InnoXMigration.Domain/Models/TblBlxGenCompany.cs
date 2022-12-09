using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblBlxGenCompany
{
    public int FgcmIdpk { get; set; }

    public string? FgcmName { get; set; }

    public string? FgcmShtName { get; set; }

    public bool? FgcmActive { get; set; }

    public string? FgcmRemarks { get; set; }

    public int? FgcmCreatedBy { get; set; }

    public int? FgcmEditedBy { get; set; }

    public DateTime? FgcmCreationDate { get; set; }

    public DateTime? FgcmEditedDate { get; set; }
}
