using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblHrCbfGiftItem
{
    public int GftIdpk { get; set; }

    public DateTime? GftDate { get; set; }

    public string? GftItem { get; set; }

    public int? GftAnniversaryIdfk { get; set; }

    public decimal? GftQuantity { get; set; }

    public decimal? GftUnitPrice { get; set; }

    public int? GftCurrencyIdfk { get; set; }

    public bool? GftActive { get; set; }

    public string? GftRmks { get; set; }

    public string? GftCreatedBy { get; set; }

    public int? GftEditedBy { get; set; }

    public DateTime? GftCreationDate { get; set; }

    public DateTime? GftEditedDate { get; set; }
}
