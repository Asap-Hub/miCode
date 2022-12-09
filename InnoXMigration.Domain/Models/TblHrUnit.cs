using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblHrUnit
{
    public int UntIdpk { get; set; }

    public string? UntName { get; set; }

    public string? UntShtName { get; set; }

    public int? UntDeptIdfk { get; set; }

    public int? UntSectionIdfk { get; set; }

    public string? UntCode { get; set; }

    public int? UntHeadEmpIdfk { get; set; }

    public DateTime? UntStartDate { get; set; }

    public DateTime? UntEndDate { get; set; }

    public bool? UntActive { get; set; }

    public string? UntRmks { get; set; }

    public int? UntCreatedBy { get; set; }

    public int? UntEditedBy { get; set; }

    public DateTime? UntCreationDate { get; set; }

    public DateTime? UntEditedDate { get; set; }
}
