using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblHrLeaveName
{
    public int LvnIdpk { get; set; }

    public string? LvnName { get; set; }

    public string? LvnShtName { get; set; }

    public DateTime? LvnStartDate { get; set; }

    public DateTime? LvnEndDate { get; set; }

    public bool? LvnActive { get; set; }

    public string? LvnRmks { get; set; }

    public int? LvnCreatedBy { get; set; }

    public int? LvnEditedBy { get; set; }

    public DateTime? LvnCreationDate { get; set; }

    public DateTime? LvnEditedDate { get; set; }
}
