using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class VwSftPpeSize
{
    public int PszIdpk { get; set; }

    public string? PszName { get; set; }

    public string? PszShtName { get; set; }

    public int? PszPpeTypeIdfk { get; set; }

    public bool? PszActive { get; set; }

    public int PtpIdpk { get; set; }

    public string? PtpName { get; set; }

    public string? PtpShtName { get; set; }

    public string? PszRmks { get; set; }

    public bool? PtpActive { get; set; }

    public string? PtpRmks { get; set; }
}
