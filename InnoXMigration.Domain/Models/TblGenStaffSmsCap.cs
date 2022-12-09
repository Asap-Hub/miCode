using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblGenStaffSmsCap
{
    public int SscIdpk { get; set; }

    public int? SscEmpIdfk { get; set; }

    public int? SscCap { get; set; }

    public bool? SscActive { get; set; }

    public string? SscRmks { get; set; }

    public int? SscCreatedBy { get; set; }

    public int? SscEditedBy { get; set; }

    public DateTime? SscCreationDate { get; set; }

    public DateTime? SscEditedDate { get; set; }
}
