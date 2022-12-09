using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class VwPfmObjectives2
{
    public int ObjIdpk { get; set; }

    public string? ObjObjective { get; set; }

    public byte? ObjOrder { get; set; }

    public int PtvIdpk { get; set; }

    public string PtvName { get; set; } = null!;

    public string PtvShtName { get; set; } = null!;

    public string PtvQuestionsAnswered { get; set; } = null!;

    public int ThmIdpk { get; set; }

    public string ThmName { get; set; } = null!;

    public int MvsIdpk { get; set; }

    public string MvsName { get; set; } = null!;

    public DateTime? MvsStartDate { get; set; }

    public DateTime? MvsEndDate { get; set; }

    public string MvsMission { get; set; } = null!;

    public string MvsMissionSht { get; set; } = null!;

    public string MvsVision { get; set; } = null!;

    public string MvsVisionSht { get; set; } = null!;

    public byte ThmOrder { get; set; }

    public string ObjObjectiveSht { get; set; } = null!;

    public string ThmCommentary { get; set; } = null!;

    public string ObjDescription { get; set; } = null!;

    public string ObjOutcome { get; set; } = null!;
}
