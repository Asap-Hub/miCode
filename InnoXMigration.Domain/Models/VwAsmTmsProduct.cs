using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class VwAsmTmsProduct
{
    public int PrdIdpk { get; set; }

    public string? PrdName { get; set; }

    public string? PrdShtName { get; set; }

    public int? PrdServiceProviderIdfk { get; set; }

    public bool? PrdActive { get; set; }

    public string? PrdRmks { get; set; }

    public string? PrdCreatedBy { get; set; }

    public int? PrdEditedBy { get; set; }

    public DateTime? PrdCreationDate { get; set; }

    public DateTime? PrdEditedDate { get; set; }

    public int? SpdIdpk { get; set; }

    public string? SpdName { get; set; }

    public string? SpdShtName { get; set; }

    public string? SpdMainContact { get; set; }

    public string? SpdMobNos { get; set; }

    public string? SpdEmail { get; set; }

    public string? SpdTelNos { get; set; }

    public string? SpdPostalAddress { get; set; }

    public string? SpdResidentialAddress { get; set; }

    public bool? SpdActive { get; set; }
}
