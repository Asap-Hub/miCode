using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class VwHrJobsAndLevel
{
    public int JnlIdpk { get; set; }

    public DateTime? JnlDate { get; set; }

    public int? JnlJobIdfk { get; set; }

    public int? JnlLevelIdfk { get; set; }

    public bool? JnlActive { get; set; }

    public int JobIdpk { get; set; }

    public string? JobName { get; set; }

    public string? JobShtName { get; set; }

    public bool? JobActive { get; set; }

    public int JlvIdpk { get; set; }

    public string? JlvName { get; set; }

    public string? JlvShtName { get; set; }

    public bool? JlvActive { get; set; }

    public byte? JlvOrder { get; set; }
}
