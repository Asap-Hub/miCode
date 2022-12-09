using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblSlbProtectionGuarantee
{
    public int PgtIdpk { get; set; }

    public string? PgtPreparedByEmpIdfk { get; set; }

    public string? PgtPreparedBy { get; set; }

    public bool? PgtCheckedByEmpIdfk { get; set; }

    public bool? PgtActive { get; set; }

    public string? PgtRmks { get; set; }

    public int? PgtCreatedBy { get; set; }

    public int? PgtEditedBy { get; set; }

    public DateTime? PgtCreationDate { get; set; }

    public DateTime? PgtEditedDate { get; set; }
}
