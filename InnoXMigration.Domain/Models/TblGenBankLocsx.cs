using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblGenBankLocsx
{
    public int FblcIdpk { get; set; }

    public string? FblcName { get; set; }

    public string? FblcShtName { get; set; }

    public bool? FblcActive { get; set; }

    public string? FblcRmks { get; set; }

    public int? FblcCreatedBy { get; set; }

    public int? FblcEditedBy { get; set; }

    public DateTime? FblcCreationDate { get; set; }

    public DateTime? FblcEditedDate { get; set; }
}
