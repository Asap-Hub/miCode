using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblAsmTmsMaintenanceLocation
{
    public int MlcIdpk { get; set; }

    public string? MlcName { get; set; }

    public string? MlcShtName { get; set; }

    public string? MlcLocationIdfk { get; set; }

    public int? MlcTownIdfk { get; set; }

    public string? MlcMainContacts { get; set; }

    public string? MlcTelNos { get; set; }

    public string? MlcEmails { get; set; }

    public bool? MlcActive { get; set; }

    public string? MlcRmks { get; set; }

    public string? MlcCreatedBy { get; set; }

    public int? MlcEditedBy { get; set; }

    public DateTime? MlcCreationDate { get; set; }

    public DateTime? MlcEditedDate { get; set; }
}
