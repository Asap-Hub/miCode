using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblGenAdgroupsMember
{
    public int AgmIdpk { get; set; }

    public int? AgmEmpIdfk { get; set; }

    public string? AgmGroup { get; set; }

    public string? AgmDisplayName { get; set; }

    public string? AgmActualGroupName { get; set; }

    public bool? AgmActive { get; set; }

    public string? AgmRmks { get; set; }

    public int? AgmCreatedby { get; set; }

    public int? AgmLastEditedBy { get; set; }

    public DateTime? AgmCreationDate { get; set; }

    public DateTime? AgmLastEditedDate { get; set; }
}
