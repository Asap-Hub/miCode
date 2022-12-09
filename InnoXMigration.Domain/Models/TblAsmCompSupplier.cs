using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblAsmCompSupplier
{
    public int SplIdpk { get; set; }

    public string? SplName { get; set; }

    public string? SplShtName { get; set; }

    public string? SplMobNos { get; set; }

    public string? SplEmail { get; set; }

    public string? SplTelNos { get; set; }

    public string? SplPostalAddress { get; set; }

    public string? SplResidentialAddress { get; set; }

    public bool? SplActive { get; set; }

    public string? SplRmks { get; set; }

    public int? SplCreatedBy { get; set; }

    public int? SplEditedBy { get; set; }

    public DateTime? SplCreationDate { get; set; }

    public DateTime? SplEditedDate { get; set; }
}
