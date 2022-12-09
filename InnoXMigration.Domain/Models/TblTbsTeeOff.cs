using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblTbsTeeOff
{
    public int TofIdpk { get; set; }

    public DateTime? TofDate { get; set; }

    public DateTime? TofEndDate { get; set; }

    public int? TofParentIdfk { get; set; }

    public int? TofParentCustIdfk { get; set; }

    public int? TofParentSstIdfk { get; set; }

    public int? TofChildIdfk { get; set; }

    public int? TofChildCustIdfk { get; set; }

    public int? TofChildSstIdfk { get; set; }

    public bool? TofActive { get; set; }

    public string? TofRmks { get; set; }

    public int? TofCreatedBy { get; set; }

    public int? TofEditedBy { get; set; }

    public DateTime? TofCreationDate { get; set; }

    public DateTime? TofEditedDate { get; set; }
}
