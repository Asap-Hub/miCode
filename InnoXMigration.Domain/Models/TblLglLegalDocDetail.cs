using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblLglLegalDocDetail
{
    public int LddIdpk { get; set; }

    public int? LddCaseIdfk { get; set; }

    public string? LddDocTitle { get; set; }

    public DateTime? LddDocDate { get; set; }

    public int? LddDocTypeIdfk { get; set; }

    public string? LddRmks { get; set; }

    public bool? LddHasAttachment { get; set; }

    public int? LddCreatedBy { get; set; }

    public int? LddEditedBy { get; set; }

    public DateTime? LddCreationDate { get; set; }

    public DateTime? LddEditedDate { get; set; }
}
