using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class VwSftWasacoLocation
{
    public int WlcIdpk { get; set; }

    public string? WlcName { get; set; }

    public string? WlcShtName { get; set; }

    public bool? WlcActive { get; set; }

    public string? WlcRmks { get; set; }

    public int WstIdpk { get; set; }

    public string? WstName { get; set; }

    public string? WstShtName { get; set; }

    public bool? WstActive { get; set; }

    public int SgpIdpk { get; set; }

    public string? SgpName { get; set; }

    public string? SgpShtName { get; set; }

    public string? SgpCodeName { get; set; }

    public int? WlcWasacoStationIdfk { get; set; }
}
