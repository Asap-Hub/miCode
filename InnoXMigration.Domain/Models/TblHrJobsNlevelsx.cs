using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblHrJobsNlevelsx
{
    public int FjnlIdpk { get; set; }

    public DateTime? FjnlDate { get; set; }

    public int? FjnlJobIdfk { get; set; }

    public int? FjnlLevelIdfk { get; set; }

    public bool? FjnlActive { get; set; }

    public string? FjnlRmks { get; set; }

    public int? FjnlCreatedBy { get; set; }

    public int? FjnlEditedBy { get; set; }

    public DateTime? FjnlCreationDate { get; set; }

    public DateTime? FjnlEditedDate { get; set; }
}
