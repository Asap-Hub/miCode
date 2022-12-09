using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class VwSlbSyncDetail
{
    public int SdtIdpk { get; set; }

    public int? SdtStationIdfk { get; set; }

    public DateTime? SdtLastSyncDate { get; set; }

    public int StnIdpk { get; set; }

    public string StnName { get; set; } = null!;

    public string StnShtName { get; set; } = null!;

    public bool StnActive { get; set; }

    public bool? SdtActive { get; set; }

    public int SdtRecordsOnLocalServer { get; set; }

    public int SdtRecordsOnProductionServer { get; set; }
}
