using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class VwAsmTamStation
{
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

    public bool LocActive { get; set; }

    public string AreName { get; set; } = null!;

    public string AreShtName { get; set; } = null!;

    public bool AreActive { get; set; }

    public int AreIdpk { get; set; }

    public string StnRmks { get; set; } = null!;

    public bool StnMasterStation { get; set; }

    public bool StnNationalControlCenter { get; set; }

    public bool StnOperational { get; set; }

    public bool StnSubstation { get; set; }

    public bool StnManned { get; set; }

    public bool StnMannedByUs { get; set; }

    public bool StnOwnedByUs { get; set; }

    public int RgnIdpk { get; set; }

    public string RgnName { get; set; } = null!;

    public string RgnShtName { get; set; } = null!;

    public int CtyIdpk { get; set; }

    public string CtyName { get; set; } = null!;

    public string CtyShtName { get; set; } = null!;

    public string CtyNationality { get; set; } = null!;

    public string RgnCapital { get; set; } = null!;

    public string CtyCapital { get; set; } = null!;

    public string StnManager { get; set; } = null!;

    public string StnSupervisor { get; set; } = null!;

    public decimal StnLatitude { get; set; }

    public decimal StnLongitude { get; set; }

    public string StnEmail { get; set; } = null!;

    public string StnTown { get; set; } = null!;

    public bool StnHasComputer { get; set; }

    public bool StnHasNetwork { get; set; }

    public bool StnElogging { get; set; }

    public bool StnStatusGood { get; set; }

    public string StnDirector { get; set; } = null!;

    public bool StnGenStation { get; set; }

    public bool StnShowInElogBook { get; set; }

    public bool StnSyncLocalLogs { get; set; }

    public string StnLocalSyncServerIp { get; set; } = null!;

    public string StnLocalSyncServerName { get; set; } = null!;

    public string StnEvenRowsColour { get; set; } = null!;

    public string StnFlaggedRowsColour { get; set; } = null!;
}
