using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class VwSftWasacoStation
{
    public int WstIdpk { get; set; }

    public string? WstName { get; set; }

    public string? WstShtName { get; set; }

    public bool? WstActive { get; set; }

    public string? WstRmks { get; set; }

    public int SgpIdpk { get; set; }

    public string? SgpName { get; set; }

    public string? SgpShtName { get; set; }

    public string? SgpCodeName { get; set; }
}
