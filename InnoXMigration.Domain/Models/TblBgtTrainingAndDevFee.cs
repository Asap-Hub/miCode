using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblBgtTrainingAndDevFee
{
    public int TdfIdpk { get; set; }

    public int? TdfTrainingDevIdfk { get; set; }

    public decimal? TdfLocalFee { get; set; }

    public decimal? TdfForexFee { get; set; }

    public decimal? TdfForexFeeLocalCurrencyEquivalent { get; set; }

    public int? TdforexCurrencyIdfk { get; set; }

    public string? TdfDescription { get; set; }

    public bool? TdfActive { get; set; }

    public string? TdfRmks { get; set; }

    public int? TdfCreatedBy { get; set; }

    public int? TdfEditedBy { get; set; }

    public DateTime? TdfCreationDate { get; set; }

    public DateTime? TdfEditedDate { get; set; }
}
