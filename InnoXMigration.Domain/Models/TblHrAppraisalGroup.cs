using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblHrAppraisalGroup
{
    public int ApgIdpk { get; set; }

    public string? ApgName { get; set; }

    public string? ApgShtName { get; set; }

    public bool? ApgActive { get; set; }

    public string? ApgRmks { get; set; }

    public int? ApgCreatedBy { get; set; }

    public int? ApgEditedBy { get; set; }

    public DateTime? ApgCreationDate { get; set; }

    public DateTime? ApgEditedDate { get; set; }
}
