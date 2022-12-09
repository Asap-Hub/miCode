using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblAsmTmsFuelType
{
    public int FtpIdpk { get; set; }

    public string? FtpName { get; set; }

    public string? FtpShtName { get; set; }

    public bool? FtpActive { get; set; }

    public string? FtpRmks { get; set; }

    public string? FtpCreatedBy { get; set; }

    public int? FtpEditedBy { get; set; }

    public DateTime? FtpCreationDate { get; set; }

    public DateTime? FtpEditedDate { get; set; }
}
