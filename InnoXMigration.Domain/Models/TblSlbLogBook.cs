using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblSlbLogBook
{
    public int LbkIdpk { get; set; }

    public DateTime? LbkLogDate { get; set; }

    public int? LbkEventTypeIdfk { get; set; }

    public int? LbkLogStationIdfk { get; set; }

    public int? LbkHomeStationIdfk { get; set; }

    public int? LbkCorrespondentIdfk { get; set; }

    public bool? LbkDeleted { get; set; }

    public string? LbkEvent { get; set; }

    public bool? LbkFirstLog { get; set; }

    public bool? LbkFlag { get; set; }

    public bool? LbkSynced { get; set; }

    public bool? LbkComment { get; set; }

    public bool? LbkActive { get; set; }

    public string? LbkRmks { get; set; }

    public int? LbkCreatedBy { get; set; }

    public int? LbkEditedBy { get; set; }

    public DateTime? LbkCreationDate { get; set; }

    public DateTime? LbkEditedDate { get; set; }

    public DateTime? LbkLastSyncedOn { get; set; }
}
