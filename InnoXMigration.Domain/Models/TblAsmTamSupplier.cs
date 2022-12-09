using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblAsmTamSupplier
{
    public int SplIdpk { get; set; }

    public string? SplName { get; set; }

    public string? SplShtName { get; set; }

    public bool? SplActive { get; set; }

    public string? SplRmks { get; set; }

    public string? SplCreatedBy { get; set; }

    public int? SplEditedBy { get; set; }

    public DateTime? SplCreationDate { get; set; }

    public DateTime? SplEditedDate { get; set; }
}
