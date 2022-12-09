using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblSlbRemoteShiftChange
{
    public int RscIdpk { get; set; }

    public int? RscInitiatorEmpIdfk { get; set; }

    public string? RscRemoteOperatorEmpIdfk { get; set; }

    public int? RscStationIdfk { get; set; }

    public DateTime? RscRequestTime { get; set; }

    public DateTime? RscTimeAccepted { get; set; }

    public bool? RscActive { get; set; }

    public string? RscRmks { get; set; }

    public int? RscCreatedBy { get; set; }

    public int? RscEditedBy { get; set; }

    public DateTime? RscCreationDate { get; set; }

    public DateTime? RscEditedDate { get; set; }
}
