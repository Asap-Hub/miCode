using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblLglTeamMember
{
    public int TmbIdpk { get; set; }

    public int? TmbEmpIdfk { get; set; }

    public int? TmbTeamIdfk { get; set; }

    public bool? TmbActive { get; set; }

    public string? TmbRmks { get; set; }

    public int? TmbCreatedBy { get; set; }

    public int? TmbEditedBy { get; set; }

    public DateTime? TmbCreationDate { get; set; }

    public DateTime? TmbEditedDate { get; set; }
}
