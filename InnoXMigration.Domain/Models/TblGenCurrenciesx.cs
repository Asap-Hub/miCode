using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblGenCurrenciesx
{
    public int FcurIdpk { get; set; }

    public string? FcurName { get; set; }

    public DateTime? FcurDate { get; set; }

    public string? FcurShtName { get; set; }

    public string? FcurSymbol { get; set; }

    public bool? FcurForeign { get; set; }

    public byte? FcurOrder { get; set; }

    public bool? FcurActive { get; set; }

    public string? FcurRmks { get; set; }

    public int? FcurCreatedBy { get; set; }

    public int? FcurEditedBy { get; set; }

    public DateTime? FcurCreationDate { get; set; }

    public DateTime? FcurEditedDate { get; set; }
}
