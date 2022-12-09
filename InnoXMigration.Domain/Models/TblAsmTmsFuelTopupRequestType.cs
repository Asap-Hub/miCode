using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblAsmTmsFuelTopupRequestType
{
    public int FttIdpk { get; set; }

    public string? FttName { get; set; }

    public string? FttShtName { get; set; }

    public bool? FttActive { get; set; }

    public string? FttRmks { get; set; }

    public int? FttCreatedBy { get; set; }

    public int? FttEditedBy { get; set; }

    public DateTime? FttCreationDate { get; set; }

    public DateTime? FttEditedDate { get; set; }
}
