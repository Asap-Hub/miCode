using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblAsmTamStation
{
    public int StnIdpk { get; set; }

    public string? StnName { get; set; }

    public string? StnShtName { get; set; }

    public string? StnCode { get; set; }

    public string? StnContact { get; set; }

    public string? StnTelNo { get; set; }

    public string? StnPlc { get; set; }

    public string? StnEmail { get; set; }

    public int? StnLocationIdfk { get; set; }

    public decimal? StnLatitude { get; set; }

    public decimal? StnLongitude { get; set; }

    public string? StnLocalSyncServerIp { get; set; }

    public string? StnLocalSyncServerName { get; set; }

    public int? StnRegionIdfk { get; set; }

    public string? StnTown { get; set; }

    public string? StnDirector { get; set; }

    public string? StnManager { get; set; }

    public string? StnSupervisor { get; set; }

    public bool? StnSubstation { get; set; }

    public bool? StnGenStation { get; set; }

    public bool? StnMasterStation { get; set; }

    public bool? StnNationalControlCenter { get; set; }

    public bool? StnSyncLocalLogs { get; set; }

    public bool? StnOperational { get; set; }

    public bool? StnManned { get; set; }

    public bool? StnMannedByUs { get; set; }

    public bool? StnOwnedByUs { get; set; }

    public bool? StnHasComputer { get; set; }

    public bool? StnHasNetwork { get; set; }

    public bool? StnShowInElogBook { get; set; }

    public bool? StnElogging { get; set; }

    public bool? StnStatusGood { get; set; }

    public string? StnEvenRowsColour { get; set; }

    public string? StnFlaggedRowsColour { get; set; }

    public bool? StnActive { get; set; }

    public string? StnRmks { get; set; }

    public int? StnCreatedBy { get; set; }

    public int? StnEditedBy { get; set; }

    public DateTime? StnCreationDate { get; set; }

    public DateTime? StnEditedDate { get; set; }
}
