using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblGenSmsGroupMember
{
    public int SgmIdpk { get; set; }

    public int? SgmGroupIdfk { get; set; }

    public int? SgmEmpIdfk { get; set; }

    public bool? SgmActive { get; set; }

    public string? SgmRmks { get; set; }

    public int? SgmCreatedby { get; set; }

    public int? SgmEditedBy { get; set; }

    public DateTime? SgmCreationDate { get; set; }

    public DateTime? SgmEditedDate { get; set; }
}
