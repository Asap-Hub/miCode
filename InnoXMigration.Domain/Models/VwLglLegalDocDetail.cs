using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class VwLglLegalDocDetail
{
    public int LddIdpk { get; set; }

    public string? LddDocTitle { get; set; }

    public DateTime? LddDocDate { get; set; }

    public int? LddDocTypeIdfk { get; set; }

    public string? LddRmks { get; set; }

    public int? DtpIdpk { get; set; }

    public string? DtpName { get; set; }

    public string? DtpShtName { get; set; }

    public byte? DtpOrder { get; set; }

    public bool? DtpActive { get; set; }

    public int? PjrIdpk { get; set; }

    public string? PjrName { get; set; }

    public string? PjrShtName { get; set; }

    public DateTime? PjrStartDate { get; set; }

    public DateTime? PjrActualEndDate { get; set; }

    public DateTime? LddCreationDate { get; set; }

    public bool LddHasAttachment { get; set; }

    public int? CseIdpk { get; set; }

    public string? CseShtName { get; set; }

    public string? CseSubject { get; set; }

    public int? LddCaseIdfk { get; set; }

    public DateTime? CseReceivedDate { get; set; }

    public string? CseCounsel { get; set; }

    public string? CseCourt { get; set; }

    public int? PnmIdpk { get; set; }

    public string? PnmName { get; set; }

    public string? PnmShtName { get; set; }

    public DateTime? PnmStartDate { get; set; }

    public string? CseSuitNo { get; set; }
}
