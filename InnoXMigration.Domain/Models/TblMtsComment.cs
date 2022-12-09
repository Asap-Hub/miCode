using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblMtsComment
{
    public int CmtIdpk { get; set; }

    public int? CmtDocIdfk { get; set; }

    public int? CmtEmpIdfk { get; set; }

    public string? CmtType { get; set; }

    public string? CmtComment { get; set; }

    public string? CmtFrom { get; set; }

    public bool? CmtActive { get; set; }

    public int? CmtCreatedBy { get; set; }

    public int? CmtEditedBy { get; set; }

    public DateTime? CmtCreationDate { get; set; }

    public DateTime? CmtEditedDate { get; set; }
}
