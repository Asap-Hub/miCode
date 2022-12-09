using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblAsmRstAttendantBlockAssignment
{
    public int AbaIdpk { get; set; }

    public int? AbaEmpIdfk { get; set; }

    public int? AbaBlockIdfk { get; set; }

    public bool? AbaManage { get; set; }

    public bool? AbaView { get; set; }

    public bool? AbaActive { get; set; }

    public string? AbaRmks { get; set; }

    public int? AbaCreatedBy { get; set; }

    public int? AbaEditedBy { get; set; }

    public DateTime? AbaCreationDate { get; set; }

    public DateTime? AbaEditedDate { get; set; }
}
