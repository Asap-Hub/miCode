using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblSlbUserGroupMember
{
    public int UgmIdpk { get; set; }

    public int? UgmEmpIdfk { get; set; }

    public int? UgmGroupIdfk { get; set; }

    public bool? UgmActive { get; set; }

    public string? UgmRmks { get; set; }

    public int? UgmCreatedBy { get; set; }

    public int? UgmEditedBy { get; set; }

    public DateTime? UgmCreationDate { get; set; }

    public DateTime? UgmEditedDate { get; set; }
}
