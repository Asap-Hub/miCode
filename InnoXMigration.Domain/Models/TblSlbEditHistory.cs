using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblSlbEditHistory
{
    public int LehIdpk { get; set; }

    public int? LehLogIdfk { get; set; }

    public DateTime? LehLogLogDate { get; set; }

    public int? LehLogEventTypeIdfk { get; set; }

    public int? LehLogStationIdfk { get; set; }

    public int? LehLogCorrespondentIdfk { get; set; }

    public int? LehLogRmks { get; set; }

    public int? LehLogEditedBy { get; set; }

    public DateTime? LehLogEditedDate { get; set; }

    public DateTime? LehLogCreationDate { get; set; }

    public DateTime? LehCreationDate { get; set; }

    public int? LehCreatedBy { get; set; }
}
