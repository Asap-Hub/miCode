using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblAmgAssociationMember
{
    public int AsmIdpk { get; set; }

    public int? AsmAssociationIdfk { get; set; }

    public int? AsmEmpIdfk { get; set; }

    public DateTime? AsmStartDate { get; set; }

    public DateTime? AsmEndDate { get; set; }

    public bool? AsmSmsSent { get; set; }

    public bool? AsmSmsCount { get; set; }

    public bool? AsmDeleted { get; set; }

    public int? AsmRemovalReasonIdfk { get; set; }

    public string? AsmRemovalRemarks { get; set; }

    public bool? AsmActive { get; set; }

    public string? AsmRmks { get; set; }

    public int? AsmCreatedby { get; set; }

    public int? AsmEditedBy { get; set; }

    public DateTime? AsmCreationDate { get; set; }

    public DateTime? AsmEditedDate { get; set; }
}
