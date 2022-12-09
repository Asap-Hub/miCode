using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblPmsLessonsLog
{
    public int LlgIdpk { get; set; }

    public DateTime? LlgDate { get; set; }

    public int? LlgProjectIdfk { get; set; }

    public int? LlgTypeIdfk { get; set; }

    public int? LlgPriorityIdfk { get; set; }

    public int? LlgEffectIdfk { get; set; }

    public string? LlgEvent { get; set; }

    public string? LlgTrigger { get; set; }

    public string? LlgRecommendation { get; set; }

    public bool? LlgEarlyWarning { get; set; }

    public bool? LlgPreviouslyIdentified { get; set; }

    public bool? LlgActive { get; set; }

    public string? LlgRmks { get; set; }

    public int? LlgCreatedBy { get; set; }

    public int? LlgEditedBy { get; set; }

    public DateTime? LlgCreationDate { get; set; }

    public DateTime? LlgEditedDate { get; set; }
}
