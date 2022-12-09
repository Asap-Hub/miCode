using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblAsmTmsServiceProvider
{
    public int SpdIdpk { get; set; }

    public string? SpdName { get; set; }

    public string? SpdShtName { get; set; }

    public string? SpdMainContact { get; set; }

    public string? SpdMobNos { get; set; }

    public string? SpdEmail { get; set; }

    public string? SpdTelNos { get; set; }

    public string? SpdPostalAddress { get; set; }

    public string? SpdResidentialAddress { get; set; }

    public bool? SpdFuelDump { get; set; }

    public bool? SpdActive { get; set; }

    public string? SpdRmks { get; set; }

    public int? SpdCreatedBy { get; set; }

    public int? SpdEditedBy { get; set; }

    public DateTime? SpdCreationDate { get; set; }

    public DateTime? SpdEditedDate { get; set; }
}
