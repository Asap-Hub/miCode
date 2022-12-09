using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblAsmTmsCardDetail
{
    public int CdtIdpk { get; set; }

    public string? CdtIssueDate { get; set; }

    public string? CdtExpiryDate { get; set; }

    public string? CdtName { get; set; }

    public string? CdtShtName { get; set; }

    public int? CdtCardTypeIdfk { get; set; }

    public string? CdtCardNo { get; set; }

    public string? CdtCardPin { get; set; }

    public int? CdtServiceProviderIdfk { get; set; }

    public string? CdtProviderCardName { get; set; }

    public string? CdtProviderCardNo { get; set; }

    public string? CdtProviderCardType { get; set; }

    public int? CdtTownIdfk { get; set; }

    public bool? CdtActive { get; set; }

    public string? CdtRmks { get; set; }

    public string? CdtCreatedBy { get; set; }

    public int? CdtEditedBy { get; set; }

    public DateTime? CdtCreationDate { get; set; }

    public DateTime? CdtEditedDate { get; set; }
}
