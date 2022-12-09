using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class VwSlbBacklogSetting
{
    public int SbsIdpk { get; set; }

    public DateTime? SbsStartDate { get; set; }

    public DateTime? SbsEndDate { get; set; }

    public DateTime? SbsExpiryDate { get; set; }

    public int? SbsStationIdfk { get; set; }

    public bool? SbsActive { get; set; }

    public string? SbsRmks { get; set; }

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

    public string AreName { get; set; } = null!;

    public string AreShtName { get; set; } = null!;

    public int AreIdpk { get; set; }

    public bool StnMasterStation { get; set; }

    public string StnEvenRowsColour { get; set; } = null!;

    public bool StnNationalControlCenter { get; set; }

    public bool StnOperational { get; set; }
}
