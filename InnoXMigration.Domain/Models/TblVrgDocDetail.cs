using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblVrgDocDetail
{
    public int DdtIdpk { get; set; }

    public int? DdtCompIdfk { get; set; }

    public int? DdtDocTypeIdfk { get; set; }

    public DateTime? DdtIssueDate { get; set; }

    public DateTime? DdtExpiryDate { get; set; }

    public string? DdtName { get; set; }

    public bool? DdtActive { get; set; }

    public string? DdtRmks { get; set; }

    public int? DdtCreatedBy { get; set; }

    public int? DdtEditedBy { get; set; }

    public DateTime? DdtCreationDate { get; set; }

    public DateTime? DdtEditedDate { get; set; }
}
