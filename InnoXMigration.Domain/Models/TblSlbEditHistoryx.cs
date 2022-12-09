using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblSlbEditHistoryx
{
    public int FlehIdpk { get; set; }

    public int? FlehLogIdfk { get; set; }

    public DateTime? FlehLogLogDate { get; set; }

    public int? FlehLogEventTypeIdfk { get; set; }

    public int? FlehLogStationIdfk { get; set; }

    public int? FlehLogCorrespondentIdfk { get; set; }

    public int? FlehLogRmks { get; set; }

    public int? FlehLogEditedBy { get; set; }

    public DateTime? FlehLogEditedDate { get; set; }

    public DateTime? FlehLogCreationDate { get; set; }

    public DateTime? FlehCreationDate { get; set; }

    public int? FlehCreatedBy { get; set; }
}
