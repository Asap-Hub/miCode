using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblPjmProjectDocDetail
{
    public int PddIdpk { get; set; }

    public int? PddProjectPhaseIdfk { get; set; }

    public string? PddDocTitle { get; set; }

    public DateTime? PddDocDate { get; set; }

    public int? PddDocTypeIdfk { get; set; }

    public string? PddRmks { get; set; }

    public bool? PddHasAttachment { get; set; }

    public int? PddCreatedBy { get; set; }

    public int? PddEditedBy { get; set; }

    public DateTime? PddCreationDate { get; set; }

    public DateTime? PddEditedDate { get; set; }
}
