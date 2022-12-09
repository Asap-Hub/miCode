using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblGenSmsParameter
{
    public int SprIdpk { get; set; }

    public string? SprName { get; set; }

    public string? SprShtName { get; set; }

    public string? SprCodeName { get; set; }

    public string? SprSenderName { get; set; }

    public string? SprSmsSentFromAppName { get; set; }

    public string? SprSmsSentFromMessage { get; set; }

    public string? SprClientId { get; set; }

    public string? SprApiKey { get; set; }

    public int? SprNoOfSmsLeft { get; set; }

    public decimal? SprBalance { get; set; }

    public int? SprMinimumSmsBalance { get; set; }

    public string? SprAdminMobNos { get; set; }

    public DateTime? SprLastMinimumBalanceAlertDate { get; set; }

    public bool? SprPrimary { get; set; }

    public bool? SprActive { get; set; }

    public string? SprRmks { get; set; }

    public int? SprCreatedBy { get; set; }

    public int? SprEditedBy { get; set; }

    public DateTime? SprCreationDate { get; set; }

    public DateTime? SprEditedDate { get; set; }
}
