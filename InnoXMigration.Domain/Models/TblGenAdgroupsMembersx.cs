using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblGenAdgroupsMembersx
{
    public int AgmIdpk { get; set; }

    public int? AgmGroupIdfk { get; set; }

    public int? AgmEmpIdfk { get; set; }

    public bool? AgmActive { get; set; }

    public string? AgmRmks { get; set; }

    public int? AgmCreatedby { get; set; }

    public int? AgmLastEditedBy { get; set; }

    public DateTime? AgmCreationDate { get; set; }

    public DateTime? AgmLastEditedDate { get; set; }
}
