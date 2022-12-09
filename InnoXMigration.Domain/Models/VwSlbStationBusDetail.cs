using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class VwSlbStationBusDetail
{
    public int SbdIdpk { get; set; }

    public int? SbdStationIdfk { get; set; }

    public string? SbdName { get; set; }

    public string? SbdShtName { get; set; }

    public bool? SbdActive { get; set; }

    public string? SbdRmks { get; set; }

    public int StnIdpk { get; set; }

    public string StnName { get; set; } = null!;

    public string StnShtName { get; set; } = null!;

    public string StnCode { get; set; } = null!;

    public string StnContact { get; set; } = null!;

    public string StnTelNo { get; set; } = null!;

    public string StnPlc { get; set; } = null!;

    public int LocIdpk { get; set; }

    public string LocName { get; set; } = null!;

    public string LocShtName { get; set; } = null!;

    public bool LocActive { get; set; }

    public string AreName { get; set; } = null!;

    public string AreShtName { get; set; } = null!;

    public bool StnMasterStation { get; set; }

    public bool StnNationalControlCenter { get; set; }

    public bool StnOperational { get; set; }

    public bool StnActive { get; set; }
}
