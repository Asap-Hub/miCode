using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblHrJobsAndLevel
{
    public int JnlIdpk { get; set; }

    public DateTime? JnlDate { get; set; }

    public int? JnlJobIdfk { get; set; }

    public int? JnlLevelIdfk { get; set; }

    public bool? JnlActive { get; set; }

    public string? JnlRmks { get; set; }

    public int? JnlCreatedBy { get; set; }

    public int? JnlEditedBy { get; set; }

    public DateTime? JnlCreationDate { get; set; }

    public DateTime? JnlEditedDate { get; set; }
}
