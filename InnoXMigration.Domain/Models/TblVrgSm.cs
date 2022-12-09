using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblVrgSm
{
    public int FcsmIdpk { get; set; }

    public int? FcsmClientIdfk { get; set; }

    public string? FcsmMessage { get; set; }

    public string? FcsmMobNo { get; set; }

    public string? FcsmSender { get; set; }

    public bool? FcsmSent { get; set; }

    public int? FcsmCreatedBy { get; set; }

    public DateTime? FcsmCreationDate { get; set; }
}
