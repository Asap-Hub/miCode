using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblVrgPartCapacity
{
    public int FptcIdpk { get; set; }

    public string? FptcName { get; set; }

    public string? FptcShtName { get; set; }

    public bool? FptcActive { get; set; }

    public string? FptcRmks { get; set; }

    public int? FptcCreatedBy { get; set; }

    public int? FptcEditedBy { get; set; }

    public DateTime? FptcCreationDate { get; set; }

    public DateTime? FptcEditedDate { get; set; }
}
