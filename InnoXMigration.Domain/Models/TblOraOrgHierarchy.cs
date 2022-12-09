using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblOraOrgHierarchy
{
    public int FohrIdpk { get; set; }

    public string? FohrName { get; set; }

    public string? FohrLevelDesc { get; set; }

    public string? FohrCode { get; set; }

    public int? FohrDeptIdfk { get; set; }

    public int? FohrSectionIdfk { get; set; }

    public int? FohrUnitIdfk { get; set; }

    public string? FohrOrgType { get; set; }

    public bool FohrActive { get; set; }

    public string? FohrRmks { get; set; }

    public DateTime? FohrCreationDate { get; set; }

    public DateTime? FohrEditedDate { get; set; }

    public int? FohrEditedBy { get; set; }
}
