using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblHrDept
{
    public int DptIdpk { get; set; }

    public string? DptName { get; set; }

    public string? DptShtName { get; set; }

    public string? DptCode { get; set; }

    public int? DptBranchIdfk { get; set; }

    public int? DptDirectorEmpIdfk { get; set; }

    public DateTime? DptStartDate { get; set; }

    public DateTime? DptEndDate { get; set; }

    public bool? DptActive { get; set; }

    public string? DptRmks { get; set; }

    public int? DptCreatedBy { get; set; }

    public int? DptEditedBy { get; set; }

    public DateTime? DptCreationDate { get; set; }

    public DateTime? DptEditedDate { get; set; }
}
