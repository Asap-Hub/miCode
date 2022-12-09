using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblHrSponsor
{
    public int SpnIdpk { get; set; }

    public string? SpnName { get; set; }

    public string? SpnShtName { get; set; }

    public bool? SpnCompanySponsor { get; set; }

    public bool? SpnActive { get; set; }

    public string? SpnRmks { get; set; }

    public int? SpnCreatedBy { get; set; }

    public int? SpnEditedBy { get; set; }

    public DateTime? SpnCreationDate { get; set; }

    public DateTime? SpnEditedDate { get; set; }
}
