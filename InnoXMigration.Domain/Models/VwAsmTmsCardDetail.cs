using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class VwAsmTmsCardDetail
{
    public int CdtIdpk { get; set; }

    public string CdtCardNo { get; set; } = null!;

    public string CdtCardPin { get; set; } = null!;

    public string? CdtIssueDate { get; set; }

    public string? CdtExpiryDate { get; set; }

    public int? CdtServiceProviderIdfk { get; set; }

    public int? CdtTownIdfk { get; set; }

    public bool? CdtActive { get; set; }

    public string CdtRmks { get; set; } = null!;

    public string? CdtCreatedBy { get; set; }

    public int? CdtEditedBy { get; set; }

    public DateTime? CdtCreationDate { get; set; }

    public DateTime? CdtEditedDate { get; set; }

    public int? SpdIdpk { get; set; }

    public string? SpdName { get; set; }

    public string? SpdShtName { get; set; }

    public string? SpdMainContact { get; set; }

    public string? SpdMobNos { get; set; }

    public string? SpdEmail { get; set; }

    public string? SpdTelNos { get; set; }

    public string? SpdPostalAddress { get; set; }

    public int? TwnIdpk { get; set; }

    public string? TwnName { get; set; }

    public string? TwnShtName { get; set; }

    public int? DstIdpk { get; set; }

    public string? DstName { get; set; }

    public string? DstShtName { get; set; }

    public int? RgnIdpk { get; set; }

    public string? RgnName { get; set; }

    public string? RgnShtName { get; set; }

    public int? CtyIdpk { get; set; }

    public string? CtyName { get; set; }

    public string? CtyShtName { get; set; }

    public string? CtyNationality { get; set; }
}
