using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblGenHelpPopupEntry
{
    public int HpeIdpk { get; set; }

    public int? HpeFormIdfk { get; set; }

    public byte[]? HpeDoc { get; set; }

    public DateTime? HpeDate { get; set; }

    public decimal? HpeOrder { get; set; }

    public bool? HpeActive { get; set; }

    public string? HpeRmks { get; set; }

    public int? HpeCreatedBy { get; set; }

    public int? HpeEditedBy { get; set; }

    public DateTime? HpeCreationDate { get; set; }

    public DateTime? HpeEditedDate { get; set; }
}
