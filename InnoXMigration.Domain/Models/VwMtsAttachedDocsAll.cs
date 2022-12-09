using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class VwMtsAttachedDocsAll
{
    public int AtdIdpk { get; set; }

    public int? AtdMailIdfk { get; set; }

    public byte[]? AtdDoc { get; set; }

    public string? AtdFileName { get; set; }

    public string? AtdFileNo { get; set; }

    public string? AtdFormat { get; set; }

    public bool? AtdActive { get; set; }

    public int AttIdpk { get; set; }

    public string? AttName { get; set; }

    public string? AttShtName { get; set; }

    public bool? AttActive { get; set; }

    public string? AttRmks { get; set; }

    public string? AtdSubject { get; set; }

    public int MtrIdpk { get; set; }

    public DateTime? MtrDocDate { get; set; }

    public DateTime? MtrRecDate { get; set; }

    public DateTime? MtrOutDate { get; set; }

    public string MtrSubject { get; set; } = null!;

    public string MtrSummaryContent { get; set; } = null!;

    public string MtrIncomingNotes { get; set; } = null!;

    public string MtrOutgoingMinutes { get; set; } = null!;

    public string DocSrcItemName { get; set; } = null!;

    public string DocSrcItemShtName { get; set; } = null!;

    public string FwdFromItemName { get; set; } = null!;

    public string FwdFromItemShtName { get; set; } = null!;

    public string? EmpStaffNo { get; set; }

    public string? UsaUsername { get; set; }

    public string? EmpName { get; set; }

    public string? EmpName1 { get; set; }

    public string? EmpName2 { get; set; }

    public string MtrCc { get; set; } = null!;

    public string MtrOutTo { get; set; } = null!;

    public string MtrBcc { get; set; } = null!;

    public int? DtpIdpk { get; set; }

    public string? DtpName { get; set; }

    public string? DtpShtName { get; set; }

    public string? DtpCode { get; set; }

    public int? DcsIdpk { get; set; }

    public string? DcsName { get; set; }

    public string? DcsShtname { get; set; }

    public bool? AtdMainAttachment { get; set; }
}
