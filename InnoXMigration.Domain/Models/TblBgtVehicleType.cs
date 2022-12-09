using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblBgtVehicleType
{
    public int BvtIdpk { get; set; }

    public string? BvtName { get; set; }

    public string? BvtShtName { get; set; }

    public bool? BvtActive { get; set; }

    public string? BvtRmks { get; set; }

    public int? BvtCreatedBy { get; set; }

    public int? BvtEditedBy { get; set; }

    public DateTime? BvtCreationDate { get; set; }

    public DateTime? BvtEditedDate { get; set; }
}
