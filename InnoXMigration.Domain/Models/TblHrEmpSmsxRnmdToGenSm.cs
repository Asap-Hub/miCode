using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblHrEmpSmsxRnmdToGenSm
{
    public int FetmIdpk { get; set; }

    public int? FetmEmpIdfk { get; set; }

    public string? FetmMobNo { get; set; }

    public string? FetmMessage { get; set; }

    public string? FetmOwner { get; set; }

    public string? FetmSender { get; set; }

    public bool? FetmSent { get; set; }

    public string? FetmRmks { get; set; }

    public int? FetmCreatedBy { get; set; }

    public DateTime? FetmCreationDate { get; set; }
}
