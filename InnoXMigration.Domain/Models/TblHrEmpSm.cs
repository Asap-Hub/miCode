using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblHrEmpSm
{
    public int EsmIdpk { get; set; }

    public int? EsmEmpIdfk { get; set; }

    public string? EsmMobNo { get; set; }

    public string? EsmMessage { get; set; }

    public string? EsmOwner { get; set; }

    public string? EsmSender { get; set; }

    public bool? EsmSent { get; set; }

    public string? EsmRmks { get; set; }

    public int? EsmCreatedBy { get; set; }

    public DateTime? EsmCreationDate { get; set; }
}
