using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblAsmTmsExamsQuestion
{
    public int ExqIdpk { get; set; }

    public string? ExqTitle { get; set; }

    public int? ExqExamCategoryIdfk { get; set; }

    public byte[]? ExqQuestion { get; set; }

    public bool? ExqActive { get; set; }

    public bool? ExqPracticeQuestion { get; set; }

    public bool? ExqMultipleCorrectAnswers { get; set; }

    public string? ExqRmks { get; set; }

    public int? ExqCreatedBy { get; set; }

    public int? ExqEditedBy { get; set; }

    public DateTime? ExqCreationDate { get; set; }

    public DateTime? ExqEditedDate { get; set; }
}
