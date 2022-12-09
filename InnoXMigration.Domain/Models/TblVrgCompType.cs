using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblVrgCompType
{
    public int FcmtIdpk { get; set; }

    public string? FcmtName { get; set; }

    public string? FcmtShtName { get; set; }

    public bool? FcmtActive { get; set; }

    public string? FcmtRmks { get; set; }

    public int? FcmtCreatedBy { get; set; }

    public int? FcmtEditedBy { get; set; }

    public DateTime? FcmtCreationDate { get; set; }

    public DateTime? FcmtEditedDate { get; set; }
}
