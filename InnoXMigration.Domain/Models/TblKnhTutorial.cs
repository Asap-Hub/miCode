using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblKnhTutorial
{
    public int TutIdpk { get; set; }

    public int? TutCategoryIdfk { get; set; }

    public string? TutTitle { get; set; }

    public byte[]? TutContent { get; set; }

    public decimal? TutOrder { get; set; }

    public string? TutRmks { get; set; }

    public bool? TutActive { get; set; }

    public int? TutCreatedBy { get; set; }

    public int? TutEditedBy { get; set; }

    public DateTime? TutCreationDate { get; set; }

    public DateTime? TutEditedDate { get; set; }
}
