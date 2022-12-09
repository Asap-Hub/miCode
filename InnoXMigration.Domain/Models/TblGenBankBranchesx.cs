using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblGenBankBranchesx
{
    public int FbbrIdpk { get; set; }

    public string? FbbrName { get; set; }

    public string? FbbrShtName { get; set; }

    public int? FbbrLocIdfk { get; set; }

    public bool? FbbrActive { get; set; }

    public string? FbbrRmks { get; set; }

    public int? FbbrCreatedBy { get; set; }

    public int? FbbrEditedBy { get; set; }

    public DateTime? FbbrCreationDate { get; set; }

    public DateTime? FbbrEditedDate { get; set; }
}
