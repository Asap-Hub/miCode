using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblGenCurrency
{
    public int CurIdpk { get; set; }

    public string? CurName { get; set; }

    public DateTime? CurDate { get; set; }

    public string? CurShtName { get; set; }

    public string? CurSymbol { get; set; }

    public bool? CurForeign { get; set; }

    public byte? CurOrder { get; set; }

    public bool? CurActive { get; set; }

    public string? CurRmks { get; set; }

    public int? CurCreatedBy { get; set; }

    public int? CurEditedBy { get; set; }

    public DateTime? CurCreationDate { get; set; }

    public DateTime? CurEditedDate { get; set; }
}
