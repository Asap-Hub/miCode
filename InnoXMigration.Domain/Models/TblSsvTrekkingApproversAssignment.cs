using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblSsvTrekkingApproversAssignment
{
    public int TaaIdpk { get; set; }

    public int? TaaEmpIdfk { get; set; }

    public int? TaaTrekkingLocationIdfk { get; set; }

    public bool? TaaApproveStopOver { get; set; }

    public bool? TaaApproveSleepOver { get; set; }

    public bool? TaaActive { get; set; }

    public string? TaaRmks { get; set; }

    public int? TaaCreatedBy { get; set; }

    public int? TaaEditedBy { get; set; }

    public DateTime? TaaCreationDate { get; set; }

    public DateTime? TaaEditedDate { get; set; }
}
