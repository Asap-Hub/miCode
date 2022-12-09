using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblSlbSyncDetail
{
    public int SdtIdpk { get; set; }

    public int? SdtStationIdfk { get; set; }

    public DateTime? SdtLastSyncDate { get; set; }

    public int? SdtRecordsOnLocalServer { get; set; }

    public int? SdtRecordsOnProductionServer { get; set; }

    public bool? SdtActive { get; set; }

    public string? SdtRmks { get; set; }

    public int? SdtCreatedBy { get; set; }

    public int? SdtEditedBy { get; set; }

    public DateTime? SdtCreationDate { get; set; }

    public DateTime? SdtEditedDate { get; set; }
}
