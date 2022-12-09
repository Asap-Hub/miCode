using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblAsmTamGenerationCompany
{
    public int GcmIdpk { get; set; }

    public string? GcmName { get; set; }

    public string? GcmShtName { get; set; }

    public int? GcmLocationIdfk { get; set; }

    public string? GcmContacts { get; set; }

    public string? GcmMobNos { get; set; }

    public string? GcmTelNos { get; set; }

    public string? GcmEmail { get; set; }

    public string? GcmAddress { get; set; }

    public bool? GcmActive { get; set; }

    public string? GcmRmks { get; set; }

    public int? GcmCreatedBy { get; set; }

    public int? GcmEditedBy { get; set; }

    public DateTime? GcmCreationDate { get; set; }

    public DateTime? GcmEditedDate { get; set; }
}
