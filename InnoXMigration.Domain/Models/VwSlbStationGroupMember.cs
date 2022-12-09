using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class VwSlbStationGroupMember
{
    public int SgmIdpk { get; set; }

    public int? SgmGroupIdfk { get; set; }

    public bool? SgmActive { get; set; }

    public string? SgmRmks { get; set; }

    public int SgpIdpk { get; set; }

    public string? SgpName { get; set; }

    public string? SgpShtName { get; set; }

    public decimal? SgpOrder { get; set; }

    public bool? SgpActive { get; set; }

    public int StnIdpk { get; set; }

    public string StnName { get; set; } = null!;

    public string StnShtName { get; set; } = null!;

    public string StnCode { get; set; } = null!;

    public string StnContact { get; set; } = null!;

    public string StnTelNo { get; set; } = null!;

    public string StnPlc { get; set; } = null!;

    public bool StnActive { get; set; }

    public int LocIdpk { get; set; }

    public string LocName { get; set; } = null!;

    public string LocShtName { get; set; } = null!;

    public int AreIdpk { get; set; }

    public string AreName { get; set; } = null!;

    public string AreShtName { get; set; } = null!;

    public bool AreActive { get; set; }

    public int? SgmStationIdfk { get; set; }

    public bool FstnShowInElogBook { get; set; }
}
