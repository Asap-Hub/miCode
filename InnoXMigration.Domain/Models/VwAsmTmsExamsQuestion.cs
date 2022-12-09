using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class VwAsmTmsExamsQuestion
{
    public int ExqIdpk { get; set; }

    public string? ExqTitle { get; set; }

    public int? ExqExamCategoryIdfk { get; set; }

    public byte[]? ExqQuestion { get; set; }

    public bool? ExqPracticeQuestion { get; set; }

    public bool? ExqActive { get; set; }

    public string? ExqRmks { get; set; }

    public int ExcIdpk { get; set; }

    public string? ExcName { get; set; }

    public string? ExcShtName { get; set; }

    public bool? ExcActive { get; set; }

    public string? ExcRmks { get; set; }

    public bool? ExqMultipleCorrectAnswers { get; set; }
}
