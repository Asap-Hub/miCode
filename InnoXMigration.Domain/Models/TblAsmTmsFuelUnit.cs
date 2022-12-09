using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblAsmTmsFuelUnit
{
    public int FunIdpk { get; set; }

    public string? FunName { get; set; }

    public string? FunShtName { get; set; }

    public bool? FunActive { get; set; }

    public string? FunRmks { get; set; }

    public string? FunCreatedBy { get; set; }

    public int? FunEditedBy { get; set; }

    public DateTime? FunCreationDate { get; set; }

    public DateTime? FunEditedDate { get; set; }
}
