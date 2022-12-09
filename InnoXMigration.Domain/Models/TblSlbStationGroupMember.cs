using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblSlbStationGroupMember
{
    public int SgmIdpk { get; set; }

    public int? SgmStationIdfk { get; set; }

    public int? SgmGroupIdfk { get; set; }

    public bool? SgmActive { get; set; }

    public string? SgmRmks { get; set; }

    public int? SgmCreatedBy { get; set; }

    public int? SgmEditedBy { get; set; }

    public DateTime? SgmCreationDate { get; set; }

    public DateTime? SgmEditedDate { get; set; }
}
