using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class VwSwdProjectComponent
{
    public int PcmIdpk { get; set; }

    public string? PcmName { get; set; }

    public string? PcmShtName { get; set; }

    public int? PcmProjectIdfk { get; set; }

    public bool? PcmActive { get; set; }

    public string? PcmRmks { get; set; }

    public int PrjIdpk { get; set; }

    public string? PrjName { get; set; }

    public string? PrjShtName { get; set; }

    public byte? PcmOrder { get; set; }
}
