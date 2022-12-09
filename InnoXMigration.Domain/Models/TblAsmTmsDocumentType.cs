using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblAsmTmsDocumentType
{
    public int DtpIdpk { get; set; }

    public string? DtpName { get; set; }

    public string? DtpShtName { get; set; }

    public bool? DtpDriversLicense { get; set; }

    public bool? DtpActive { get; set; }

    public string? DtpRmks { get; set; }

    public string? DtpCreatedBy { get; set; }

    public int? DtpEditedBy { get; set; }

    public DateTime? DtpCreationDate { get; set; }

    public DateTime? DtpEditedDate { get; set; }
}
