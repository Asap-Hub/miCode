using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblGenSmsLog
{
    public int SlgIdpk { get; set; }

    public string? SlgMessage { get; set; }

    public string? SlgMobNo { get; set; }

    public string? SlgSender { get; set; }

    public bool? SlgSent { get; set; }

    public int? SlgRecordIdfk { get; set; }

    public string? SlgFormCode { get; set; }

    public int? SlgEmpIdfk { get; set; }

    public string? SlgType { get; set; }

    public string? SlgClass { get; set; }

    public string? SlgSmsServiceProvider { get; set; }

    public int? SlgInitiatorEmpIdfk { get; set; }

    public int? SlgCreatedBy { get; set; }

    public DateTime? SlgCreationDate { get; set; }
}
