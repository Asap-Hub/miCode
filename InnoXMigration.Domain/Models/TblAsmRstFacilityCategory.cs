using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblAsmRstFacilityCategory
{
    public int FtcIdpk { get; set; }

    public string? FtcName { get; set; }

    public string? FtcShtName { get; set; }

    public int? FtcOrder { get; set; }

    public bool? FtcActive { get; set; }

    public string? FtcRmks { get; set; }

    public string? FtcCreatedBy { get; set; }

    public int? FtcEditedBy { get; set; }

    public DateTime? FtcCreationDate { get; set; }

    public DateTime? FtcEditedDate { get; set; }
}
