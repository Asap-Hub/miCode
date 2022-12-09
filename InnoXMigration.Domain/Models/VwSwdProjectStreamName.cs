using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class VwSwdProjectStreamName
{
    public int PsnIdpk { get; set; }

    public string? PsnName { get; set; }

    public string? PsnShtName { get; set; }

    public int? PsnProjectIdfk { get; set; }

    public bool? PsnActive { get; set; }

    public string? PsnRmks { get; set; }

    public int PrjIdpk { get; set; }

    public string? PrjName { get; set; }

    public string? PrjShtName { get; set; }

    public bool? PsnMasterStream { get; set; }
}
