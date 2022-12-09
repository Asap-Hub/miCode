using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblPmsProjectSetting
{
    public int PstIdpk { get; set; }

    public string? PstProjectIdfk { get; set; }

    public string? PstDurationUnit { get; set; }

    public bool? PstActive { get; set; }

    public string? PstRmks { get; set; }

    public int? PstCreatedBy { get; set; }

    public int? PstEditedBy { get; set; }

    public DateTime? PstCreationDate { get; set; }

    public DateTime? PstEditedDate { get; set; }
}
