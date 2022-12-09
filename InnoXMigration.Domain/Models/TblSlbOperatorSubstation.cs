using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblSlbOperatorSubstation
{
    public int OsaIdpk { get; set; }

    public string? OsaOprIdfk { get; set; }

    public string? OsaSstIdfk { get; set; }

    public bool? OsaActive { get; set; }

    public string? OsaRmks { get; set; }

    public int? OsaCreatedBy { get; set; }

    public int? OsaEditedBy { get; set; }

    public DateTime? OsaCreationDate { get; set; }

    public DateTime? OsaEditedDate { get; set; }
}
