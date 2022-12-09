using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblSlbStationsx
{
    public int FstnIdpk { get; set; }

    public string? FstnName { get; set; }

    public string? FstnShtName { get; set; }

    public string? FstnCode { get; set; }

    public string? FstnContact { get; set; }

    public string? FstnTelNo { get; set; }

    public string? FstnPlc { get; set; }

    public string? FstnEmail { get; set; }

    public int? FstnLocationIdfk { get; set; }

    public decimal? FstnLatitude { get; set; }

    public decimal? FstnLongitude { get; set; }

    public string? FstnLocalSyncServerIp { get; set; }

    public string? FstnLocalSyncServerName { get; set; }

    public int? FstnRegionIdfk { get; set; }

    public string? FstnTown { get; set; }

    public string? FstnDirector { get; set; }

    public string? FstnManager { get; set; }

    public string? FstnSupervisor { get; set; }

    public bool? FstnSubstation { get; set; }

    public bool? FstnGenStation { get; set; }

    public bool? FstnMasterStation { get; set; }

    public bool? FstnNationalControlCenter { get; set; }

    public bool? FstnSyncLocalLogs { get; set; }

    public bool? FstnOperational { get; set; }

    public bool? FstnManned { get; set; }

    public bool? FstnMannedByUs { get; set; }

    public bool? FstnOwnedByUs { get; set; }

    public bool? FstnHasComputer { get; set; }

    public bool? FstnHasNetwork { get; set; }

    public bool? FstnShowInElogBook { get; set; }

    public bool? FstnElogging { get; set; }

    public bool? FstnStatusGood { get; set; }

    public string? FstnColour { get; set; }

    public bool? FstnActive { get; set; }

    public string? FstnRmks { get; set; }

    public int? FstnCreatedBy { get; set; }

    public int? FstnEditedBy { get; set; }

    public DateTime? FstnCreationDate { get; set; }

    public DateTime? FstnEditedDate { get; set; }
}
