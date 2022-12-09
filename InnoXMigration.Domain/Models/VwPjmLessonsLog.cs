using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class VwPjmLessonsLog
{
    public int LlgIdpk { get; set; }

    public DateTime? LlgDate { get; set; }

    public string LlgTrigger { get; set; } = null!;

    public string LlgEvent { get; set; } = null!;

    public string LlgRecommendation { get; set; } = null!;

    public bool LlgEarlyWarning { get; set; }

    public bool LlgPreviouslyIdentified { get; set; }

    public bool LlgActive { get; set; }

    public string LlgRmks { get; set; } = null!;

    public int LlgProjectIdfk { get; set; }

    public int LlgTypeIdfk { get; set; }

    public int LlgPriorityIdfk { get; set; }

    public int LlgEffectIdfk { get; set; }

    public int? PjrIdpk { get; set; }

    public string? PjrName { get; set; }

    public string? PjrShtName { get; set; }

    public int? LtpIdpk { get; set; }

    public string? LtpName { get; set; }

    public string? LtpShtName { get; set; }

    public int? PrtIdpk { get; set; }

    public string? PrtName { get; set; }

    public string? PrtShtName { get; set; }

    public decimal? PrtOrder { get; set; }

    public int? LetIdpk { get; set; }

    public string? LetName { get; set; }

    public string? LetShtName { get; set; }
}
