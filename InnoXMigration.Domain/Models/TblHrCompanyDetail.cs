using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblHrCompanyDetail
{
    public short CdtIdpk { get; set; }

    public DateTime? CdtDate { get; set; }

    public string? CdtName { get; set; }

    public string? CdtShtName { get; set; }

    public string? CdtAddress1 { get; set; }

    public string? CdtAddress2 { get; set; }

    public string? CdtLocation { get; set; }

    public string? CdtTel1 { get; set; }

    public string? CdtTel2 { get; set; }

    public string? CdtTel3 { get; set; }

    public string? CdtFax1 { get; set; }

    public string? CdtFax2 { get; set; }

    public string? CdtEmail1 { get; set; }

    public string? CdtEmail2 { get; set; }

    public string? CdtWebsite { get; set; }

    public string? CdtFooter { get; set; }

    public byte[]? CdtLogo { get; set; }

    public string? CdtMissionStatement { get; set; }

    public string? CdtVisionStatement { get; set; }

    public int? CdtCreatedBy { get; set; }

    public int? CdtEditedBy { get; set; }

    public DateTime? CdtCreationDate { get; set; }

    public DateTime? CdtEditedDate { get; set; }
}
